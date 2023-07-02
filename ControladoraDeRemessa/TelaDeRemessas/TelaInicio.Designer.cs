namespace TelaDeRemessas
{
    partial class TelaInicio
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
            label1 = new Label();
            label2 = new Label();
            btn_CadastrarCliente = new Button();
            btn_CadastrarPerfil = new Button();
            btn_SelecionarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(83, 23);
            label1.Name = "label1";
            label1.Size = new Size(125, 27);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 66);
            label2.Name = "label2";
            label2.Size = new Size(198, 24);
            label2.TabIndex = 1;
            label2.Text = "O que deseja fazer?";
            // 
            // btn_CadastrarCliente
            // 
            btn_CadastrarCliente.Location = new Point(83, 120);
            btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            btn_CadastrarCliente.Size = new Size(125, 37);
            btn_CadastrarCliente.TabIndex = 2;
            btn_CadastrarCliente.Text = "Cadastrar Cliente";
            btn_CadastrarCliente.UseVisualStyleBackColor = true;
            btn_CadastrarCliente.Click += btnCadastrarCliente;
            // 
            // btn_CadastrarPerfil
            // 
            btn_CadastrarPerfil.Location = new Point(83, 185);
            btn_CadastrarPerfil.Name = "btn_CadastrarPerfil";
            btn_CadastrarPerfil.Size = new Size(125, 37);
            btn_CadastrarPerfil.TabIndex = 3;
            btn_CadastrarPerfil.Text = "Cadastrar Perfil";
            btn_CadastrarPerfil.UseVisualStyleBackColor = true;
            btn_CadastrarPerfil.Click += btnCadastrarPerfil;
            // 
            // btn_SelecionarCliente
            // 
            btn_SelecionarCliente.Location = new Point(83, 256);
            btn_SelecionarCliente.Name = "btn_SelecionarCliente";
            btn_SelecionarCliente.Size = new Size(125, 37);
            btn_SelecionarCliente.TabIndex = 4;
            btn_SelecionarCliente.Text = "Selecionar Cliente";
            btn_SelecionarCliente.UseVisualStyleBackColor = true;
            btn_SelecionarCliente.Click += btnSelecionarCliente;
            // 
            // TelaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 340);
            Controls.Add(btn_SelecionarCliente);
            Controls.Add(btn_CadastrarPerfil);
            Controls.Add(btn_CadastrarCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_CadastrarCliente;
        private Button btn_CadastrarPerfil;
        private Button btn_SelecionarCliente;
    }
}