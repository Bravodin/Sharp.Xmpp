using Sharp.Xmpp.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChatForm
{
    public partial class frmMain : Form
    {
        XmppClient client;
        public Dictionary<string,string> usuarios;
        public string host;

        public frmMain()
        {
            InitializeComponent();
            usuarios = new Dictionary<string, string>();

            

            AddSimpleText("Bem vindo.");
            AddSimpleText("Informe os dados de conexão ao lado e clique em conectar!");
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        public void AddSimpleText(string text)
        {
            textChat.Text += text + "\n";
        }

        
        public void RefreshList ()
        {
            lstUsuarios.DataSource = new BindingSource(usuarios, null);
            lstUsuarios.DisplayMember = "Value";
            lstUsuarios.ValueMember = "Key";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoUsuario frm = new SimpleChatForm.NovoUsuario(this);
            frm.ShowDialog();
        }

        void AppendText(Color color, string text)
        {
            int start = textChat.TextLength;
            textChat.AppendText(text);
            int end = textChat.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            textChat.Select(start, end - start);
            {
                textChat.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            textChat.SelectionLength = 0; // clear
        }

        private void btnEnviarTexto_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                try
                {
                    var usuario = lstUsuarios.SelectedItem;
                    string recipient = $"{((System.Collections.Generic.KeyValuePair<string, string>)usuario).Value}@{((System.Collections.Generic.KeyValuePair<string, string>)usuario).Key}";
                    client.SendMessage(recipient, txtMensagem.Text);

                    AddSimpleText($"Para:{((System.Collections.Generic.KeyValuePair<string, string>)usuario).Value}");
                    AddSimpleText($"Mensagem:{txtMensagem.Text}");
                    AddSimpleText($"");
                }
                catch (Exception ex)
                {
                    AddSimpleText($"{ex.Message}");
                }
            }
        }


        private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                this.toolStatusImg.Image = global::SimpleChatForm.Properties.Resources.online;
                client.SetStatus(Sharp.Xmpp.Im.Availability.Online);
            }
            
        }

        private void btnAusente_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                this.toolStatusImg.Image = global::SimpleChatForm.Properties.Resources.ausente;
                client.SetStatus(Sharp.Xmpp.Im.Availability.Away);
            }
        }

        private void btnOcupado_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                this.toolStatusImg.Image = global::SimpleChatForm.Properties.Resources.ocupado;
                client.SetStatus(Sharp.Xmpp.Im.Availability.Dnd);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            AddSimpleText($"Tentando conexão no host {txtHost.Text} com o usuário {txtUsuarioConexao.Text}");

            try
            {
                client = new XmppClient(txtHost.Text, txtUsuarioConexao.Text, txtSenhaUsuario.Text);

                client.Message += Client_Message;

                client.Connect();
                btnConectar.Enabled = false;
                AddSimpleText($"Conectado ao host {txtHost.Text} com o usuário {txtUsuarioConexao.Text}");
                AddSimpleText($"");
                AddSimpleText($"");
                AddSimpleText($"Adicone um usuário ao lado e envie uma mensagem para começar a interagir.");

                host = txtHost.Text;

                tabConexaoUsuario.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                AddSimpleText($"Erro ao conectar no host {txtHost.Text} com o usuário {txtUsuarioConexao.Text}");
                AddSimpleText($"{ex.Message}");
                client = null;
            }

        }

        private void Client_Message(object sender, Sharp.Xmpp.Im.MessageEventArgs e)
        {
            AddSimpleText($"Mensagem de :{e.Jid}");
            AddSimpleText($"{e.Message.Body}");
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Close();
                client = null;
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
                this.toolStatusImg.Image = global::SimpleChatForm.Properties.Resources.offline;
            }
            
        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (client != null && txtArquivo.Text != "")
            {
                client.FileTransferProgress += Client_FileTransferProgress;

                var usuario = lstUsuarios.SelectedItem;
                string recipient = $"{((System.Collections.Generic.KeyValuePair<string, string>)usuario).Value}@{((System.Collections.Generic.KeyValuePair<string, string>)usuario).Key}";

                progressBar.Step = 0;

                client.InitiateFileTransfer(recipient, txtArquivo.Text);
            }
        }

        private void Client_FileTransferProgress(object sender, Sharp.Xmpp.Extensions.FileTransferProgressEventArgs e)
        {
            progressBar.Maximum = (int)(e.Transfer.Size /100) ;
            progressBar.Step = (int)(e.Transfer.Transferred/100);
        }
    }
}
