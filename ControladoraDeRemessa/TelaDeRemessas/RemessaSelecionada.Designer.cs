namespace TelaDeRemessas
{
    partial class RemessaSelecionada
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
            label1 = new Label();
            lb_NomeCliente = new Label();
            label3 = new Label();
            lb_NumeroRemessa = new Label();
            btn_CriarRemessaEntrada = new Button();
            btn_CriarRemessaSaida = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // lb_NomeCliente
            // 
            lb_NomeCliente.AutoSize = true;
            lb_NomeCliente.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_NomeCliente.Location = new Point(114, 34);
            lb_NomeCliente.Name = "lb_NomeCliente";
            lb_NomeCliente.Size = new Size(164, 24);
            lb_NomeCliente.TabIndex = 1;
            lb_NomeCliente.Text = "Nome do Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 76);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 2;
            label3.Text = "Remessa:";
            // 
            // lb_NumeroRemessa
            // 
            lb_NumeroRemessa.AutoSize = true;
            lb_NumeroRemessa.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_NumeroRemessa.Location = new Point(138, 76);
            lb_NumeroRemessa.Name = "lb_NumeroRemessa";
            lb_NumeroRemessa.Size = new Size(198, 24);
            lb_NumeroRemessa.TabIndex = 3;
            lb_NumeroRemessa.Text = "Numero da remessa";
            // 
            // btn_CriarRemessaEntrada
            // 
            btn_CriarRemessaEntrada.Location = new Point(27, 168);
            btn_CriarRemessaEntrada.Name = "btn_CriarRemessaEntrada";
            btn_CriarRemessaEntrada.Size = new Size(75, 26);
            btn_CriarRemessaEntrada.TabIndex = 4;
            btn_CriarRemessaEntrada.Text = "Selecionar";
            btn_CriarRemessaEntrada.UseVisualStyleBackColor = true;
            btn_CriarRemessaEntrada.Click += btn_CriarRemessaEntrada_Click;
            // 
            // btn_CriarRemessaSaida
            // 
            btn_CriarRemessaSaida.Location = new Point(27, 248);
            btn_CriarRemessaSaida.Name = "btn_CriarRemessaSaida";
            btn_CriarRemessaSaida.Size = new Size(75, 26);
            btn_CriarRemessaSaida.TabIndex = 5;
            btn_CriarRemessaSaida.Text = "Selecionar";
            btn_CriarRemessaSaida.UseVisualStyleBackColor = true;
            btn_CriarRemessaSaida.Click += btn_CriarRemessaSaida_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 128);
            label5.Name = "label5";
            label5.Size = new Size(249, 24);
            label5.TabIndex = 6;
            label5.Text = "Criar remessa de entrada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 208);
            label6.Name = "label6";
            label6.Size = new Size(412, 24);
            label6.TabIndex = 7;
            label6.Text = "Criar remessa de saída e finalizar remessa";
            // 
            // RemessaSelecionada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 315);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_CriarRemessaSaida);
            Controls.Add(btn_CriarRemessaEntrada);
            Controls.Add(lb_NumeroRemessa);
            Controls.Add(label3);
            Controls.Add(lb_NomeCliente);
            Controls.Add(label1);
            Name = "RemessaSelecionada";
            Text = "RemessaSelecionada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_NomeCliente;
        private Label label3;
        private Label lb_NumeroRemessa;
        private Button btn_CriarRemessaEntrada;
        private Button btn_CriarRemessaSaida;
        private Label label5;
        private Label label6;
    }
}