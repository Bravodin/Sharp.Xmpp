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
    public partial class NovoUsuario : Form
    {
        frmMain _frmMain;
        public NovoUsuario(frmMain form)
        {
            InitializeComponent();
            this._frmMain = form;
            txtDominio.Text = form.host;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._frmMain.usuarios.Add(txtDominio.Text,txtNome.Text);
            this._frmMain.RefreshList();
            this._frmMain.AddSimpleText($"Usuário {txtNome.Text} adicionado com sucesso.");

            this.Close();
        }
    }
}
