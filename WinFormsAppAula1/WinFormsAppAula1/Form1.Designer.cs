namespace WinFormsAppAula1
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMessage = new Button();
            btn1 = new Button();
            btn2 = new Button();
            txtTexto = new TextBox();
            txtResultado = new TextBox();
            lbResultado = new Label();
            lbTexto = new Label();
            cbTimes = new ComboBox();
            rbMasculino = new RadioButton();
            rbFeminino = new RadioButton();
            txtSenha = new TextBox();
            lbSenha = new Label();
            chAtivo = new CheckBox();
            SuspendLayout();
            // 
            // btnMessage
            // 
            btnMessage.Location = new Point(453, 179);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(75, 23);
            btnMessage.TabIndex = 0;
            btnMessage.Text = "Message";
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnmessage_Click;
            btnMessage.MouseClick += btnMessage_MouseClick;
            // 
            // btn1
            // 
            btn1.Location = new Point(46, 178);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(138, 178);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(46, 66);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(167, 106);
            txtTexto.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(46, 25);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(167, 23);
            txtResultado.TabIndex = 4;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(46, 9);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado";
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Location = new Point(46, 51);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(35, 15);
            lbTexto.TabIndex = 6;
            lbTexto.Text = "Texto";
            // 
            // cbTimes
            // 
            cbTimes.FormattingEnabled = true;
            cbTimes.Items.AddRange(new object[] { "Palmeiras", "Santos", "São Paulo", "Corinthians" });
            cbTimes.Location = new Point(319, 67);
            cbTimes.Name = "cbTimes";
            cbTimes.Size = new Size(121, 23);
            cbTimes.TabIndex = 7;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(219, 67);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 8;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(219, 92);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 9;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(219, 25);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(219, 9);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 11;
            lbSenha.Text = "Senha";
            // 
            // chAtivo
            // 
            chAtivo.AutoSize = true;
            chAtivo.Location = new Point(216, 144);
            chAtivo.Name = "chAtivo";
            chAtivo.Size = new Size(54, 19);
            chAtivo.TabIndex = 12;
            chAtivo.Text = "Ativo";
            chAtivo.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 214);
            Controls.Add(chAtivo);
            Controls.Add(lbSenha);
            Controls.Add(txtSenha);
            Controls.Add(rbFeminino);
            Controls.Add(rbMasculino);
            Controls.Add(cbTimes);
            Controls.Add(lbTexto);
            Controls.Add(lbResultado);
            Controls.Add(txtResultado);
            Controls.Add(txtTexto);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMessage);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMessage;
        private Button btn1;
        private Button btn2;
        private TextBox txtTexto;
        private TextBox txtResultado;
        private Label lbResultado;
        private Label lbTexto;
        private ComboBox cbTimes;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private TextBox txtSenha;
        private Label lbSenha;
        private CheckBox chAtivo;
    }
}
