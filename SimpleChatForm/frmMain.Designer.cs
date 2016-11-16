namespace SimpleChatForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabMensagens = new System.Windows.Forms.TabControl();
            this.tabTexto = new System.Windows.Forms.TabPage();
            this.btnEnviarTexto = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.tabArquivo = new System.Windows.Forms.TabPage();
            this.btnProcuraArquivo = new System.Windows.Forms.Button();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.tabConexaoUsuario = new System.Windows.Forms.TabControl();
            this.tabConexão = new System.Windows.Forms.TabPage();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusImg = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAusente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOcupado = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.textChat = new System.Windows.Forms.RichTextBox();
            this.tabMensagens.SuspendLayout();
            this.tabTexto.SuspendLayout();
            this.tabArquivo.SuspendLayout();
            this.tabConexaoUsuario.SuspendLayout();
            this.tabConexão.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 252);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 32);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(81, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(63, 32);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // tabMensagens
            // 
            this.tabMensagens.Controls.Add(this.tabTexto);
            this.tabMensagens.Controls.Add(this.tabArquivo);
            this.tabMensagens.Location = new System.Drawing.Point(12, 341);
            this.tabMensagens.Name = "tabMensagens";
            this.tabMensagens.SelectedIndex = 0;
            this.tabMensagens.Size = new System.Drawing.Size(644, 79);
            this.tabMensagens.TabIndex = 4;
            // 
            // tabTexto
            // 
            this.tabTexto.Controls.Add(this.btnEnviarTexto);
            this.tabTexto.Controls.Add(this.txtMensagem);
            this.tabTexto.Location = new System.Drawing.Point(4, 22);
            this.tabTexto.Name = "tabTexto";
            this.tabTexto.Padding = new System.Windows.Forms.Padding(3);
            this.tabTexto.Size = new System.Drawing.Size(636, 53);
            this.tabTexto.TabIndex = 0;
            this.tabTexto.Text = "Texto";
            this.tabTexto.UseVisualStyleBackColor = true;
            // 
            // btnEnviarTexto
            // 
            this.btnEnviarTexto.Location = new System.Drawing.Point(482, 18);
            this.btnEnviarTexto.Name = "btnEnviarTexto";
            this.btnEnviarTexto.Size = new System.Drawing.Size(148, 23);
            this.btnEnviarTexto.TabIndex = 2;
            this.btnEnviarTexto.Text = "Enviar";
            this.btnEnviarTexto.UseVisualStyleBackColor = true;
            this.btnEnviarTexto.Click += new System.EventHandler(this.btnEnviarTexto_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(6, 18);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(469, 20);
            this.txtMensagem.TabIndex = 0;
            // 
            // tabArquivo
            // 
            this.tabArquivo.Controls.Add(this.btnProcuraArquivo);
            this.tabArquivo.Controls.Add(this.btnEnviarArquivo);
            this.tabArquivo.Controls.Add(this.txtArquivo);
            this.tabArquivo.Location = new System.Drawing.Point(4, 22);
            this.tabArquivo.Name = "tabArquivo";
            this.tabArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabArquivo.Size = new System.Drawing.Size(636, 53);
            this.tabArquivo.TabIndex = 1;
            this.tabArquivo.Text = "Arquivo";
            this.tabArquivo.UseVisualStyleBackColor = true;
            // 
            // btnProcuraArquivo
            // 
            this.btnProcuraArquivo.Location = new System.Drawing.Point(482, 15);
            this.btnProcuraArquivo.Name = "btnProcuraArquivo";
            this.btnProcuraArquivo.Size = new System.Drawing.Size(53, 23);
            this.btnProcuraArquivo.TabIndex = 5;
            this.btnProcuraArquivo.Text = "...";
            this.btnProcuraArquivo.UseVisualStyleBackColor = true;
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Location = new System.Drawing.Point(540, 15);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(90, 23);
            this.btnEnviarArquivo.TabIndex = 4;
            this.btnEnviarArquivo.Text = "Enviar";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(6, 18);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(469, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(6, 6);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(138, 238);
            this.lstUsuarios.TabIndex = 1;
            // 
            // tabConexaoUsuario
            // 
            this.tabConexaoUsuario.Controls.Add(this.tabConexão);
            this.tabConexaoUsuario.Controls.Add(this.tabUsuarios);
            this.tabConexaoUsuario.Location = new System.Drawing.Point(498, 19);
            this.tabConexaoUsuario.Name = "tabConexaoUsuario";
            this.tabConexaoUsuario.SelectedIndex = 0;
            this.tabConexaoUsuario.Size = new System.Drawing.Size(158, 316);
            this.tabConexaoUsuario.TabIndex = 5;
            // 
            // tabConexão
            // 
            this.tabConexão.Controls.Add(this.btnDesconectar);
            this.tabConexão.Controls.Add(this.btnConectar);
            this.tabConexão.Controls.Add(this.txtHost);
            this.tabConexão.Controls.Add(this.label3);
            this.tabConexão.Controls.Add(this.txtSenhaUsuario);
            this.tabConexão.Controls.Add(this.label2);
            this.tabConexão.Controls.Add(this.txtUsuarioConexao);
            this.tabConexão.Controls.Add(this.label1);
            this.tabConexão.Location = new System.Drawing.Point(4, 22);
            this.tabConexão.Name = "tabConexão";
            this.tabConexão.Padding = new System.Windows.Forms.Padding(3);
            this.tabConexão.Size = new System.Drawing.Size(150, 290);
            this.tabConexão.TabIndex = 0;
            this.tabConexão.Text = "Conexão";
            this.tabConexão.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(77, 248);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(70, 36);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(6, 248);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(70, 36);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(9, 103);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(135, 20);
            this.txtHost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(9, 59);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtSenhaUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txtUsuarioConexao
            // 
            this.txtUsuarioConexao.Location = new System.Drawing.Point(9, 20);
            this.txtUsuarioConexao.Name = "txtUsuarioConexao";
            this.txtUsuarioConexao.Size = new System.Drawing.Size(135, 20);
            this.txtUsuarioConexao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.lstUsuarios);
            this.tabUsuarios.Controls.Add(this.btnNovo);
            this.tabUsuarios.Controls.Add(this.btnExcluir);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(150, 290);
            this.tabUsuarios.TabIndex = 1;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStatusImg,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 426);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(666, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStatusImg
            // 
            this.toolStatusImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStatusImg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOnline,
            this.btnAusente,
            this.btnOcupado});
            this.toolStatusImg.Image = global::SimpleChatForm.Properties.Resources.offline;
            this.toolStatusImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStatusImg.Name = "toolStatusImg";
            this.toolStatusImg.Size = new System.Drawing.Size(29, 20);
            this.toolStatusImg.Text = "Online";
            // 
            // btnOnline
            // 
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(123, 22);
            this.btnOnline.Text = "Online";
            this.btnOnline.Click += new System.EventHandler(this.onlineToolStripMenuItem_Click);
            // 
            // btnAusente
            // 
            this.btnAusente.Name = "btnAusente";
            this.btnAusente.Size = new System.Drawing.Size(123, 22);
            this.btnAusente.Text = "Ausente";
            this.btnAusente.Click += new System.EventHandler(this.btnAusente_Click);
            // 
            // btnOcupado
            // 
            this.btnOcupado.Name = "btnOcupado";
            this.btnOcupado.Size = new System.Drawing.Size(123, 22);
            this.btnOcupado.Text = "Ocupado";
            this.btnOcupado.Click += new System.EventHandler(this.btnOcupado_Click);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // textChat
            // 
            this.textChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textChat.Location = new System.Drawing.Point(12, 19);
            this.textChat.Name = "textChat";
            this.textChat.Size = new System.Drawing.Size(479, 316);
            this.textChat.TabIndex = 7;
            this.textChat.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 448);
            this.Controls.Add(this.textChat);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabConexaoUsuario);
            this.Controls.Add(this.tabMensagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Simple Chat";
            this.tabMensagens.ResumeLayout(false);
            this.tabTexto.ResumeLayout(false);
            this.tabTexto.PerformLayout();
            this.tabArquivo.ResumeLayout(false);
            this.tabArquivo.PerformLayout();
            this.tabConexaoUsuario.ResumeLayout(false);
            this.tabConexão.ResumeLayout(false);
            this.tabConexão.PerformLayout();
            this.tabUsuarios.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabControl tabMensagens;
        private System.Windows.Forms.TabPage tabTexto;
        private System.Windows.Forms.Button btnEnviarTexto;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TabPage tabArquivo;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.TabControl tabConexaoUsuario;
        private System.Windows.Forms.TabPage tabConexão;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStatusImg;
        private System.Windows.Forms.ToolStripMenuItem btnOnline;
        private System.Windows.Forms.ToolStripMenuItem btnAusente;
        private System.Windows.Forms.ToolStripMenuItem btnOcupado;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.RichTextBox textChat;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnProcuraArquivo;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}

