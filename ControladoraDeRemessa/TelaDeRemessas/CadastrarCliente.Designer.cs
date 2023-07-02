namespace TelaDeRemessas
{
    partial class CadastrarCliente
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
            Label label1;
            txtbNome = new TextBox();
            btnAdicionarCliente = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtbNome
            // 
            txtbNome.Location = new Point(35, 64);
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(136, 23);
            txtbNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 21);
            label1.Name = "label1";
            label1.Size = new Size(263, 24);
            label1.TabIndex = 1;
            label1.Text = "Escreva o nome do Cliente";
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(35, 111);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(75, 23);
            btnAdicionarCliente.TabIndex = 2;
            btnAdicionarCliente.Text = "Adicionar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 181);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(label1);
            Controls.Add(txtbNome);
            Name = "CadastrarCliente";
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbNome;
        private Button btnAdicionarCliente;
    }
}