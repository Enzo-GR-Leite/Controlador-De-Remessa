namespace TelaDeRemessas
{
    partial class ClienteSelecionado
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
            lbl_clienteSelecionado = new Label();
            btn_CriarRemessa = new Button();
            btn_SelecionarRemessa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(203, 24);
            label1.TabIndex = 0;
            label1.Text = "Cliente Selecionado:";
            // 
            // lbl_clienteSelecionado
            // 
            lbl_clienteSelecionado.AutoSize = true;
            lbl_clienteSelecionado.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_clienteSelecionado.Location = new Point(221, 36);
            lbl_clienteSelecionado.Name = "lbl_clienteSelecionado";
            lbl_clienteSelecionado.Size = new Size(75, 24);
            lbl_clienteSelecionado.TabIndex = 1;
            lbl_clienteSelecionado.Text = "Cliente";
            // 
            // btn_CriarRemessa
            // 
            btn_CriarRemessa.Location = new Point(97, 83);
            btn_CriarRemessa.Name = "btn_CriarRemessa";
            btn_CriarRemessa.Size = new Size(105, 29);
            btn_CriarRemessa.TabIndex = 2;
            btn_CriarRemessa.Text = "Criar remessa";
            btn_CriarRemessa.UseVisualStyleBackColor = true;
            btn_CriarRemessa.Click += btn_CriarRemessa_Click;
            // 
            // btn_SelecionarRemessa
            // 
            btn_SelecionarRemessa.Location = new Point(80, 134);
            btn_SelecionarRemessa.Name = "btn_SelecionarRemessa";
            btn_SelecionarRemessa.Size = new Size(135, 28);
            btn_SelecionarRemessa.TabIndex = 3;
            btn_SelecionarRemessa.Text = "Selecionar remessa";
            btn_SelecionarRemessa.UseVisualStyleBackColor = true;
            btn_SelecionarRemessa.Click += btn_SelecionarRemessa_Click;
            // 
            // ClienteSelecionado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 200);
            Controls.Add(btn_SelecionarRemessa);
            Controls.Add(btn_CriarRemessa);
            Controls.Add(lbl_clienteSelecionado);
            Controls.Add(label1);
            Name = "ClienteSelecionado";
            Text = "ClienteSelecionado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_clienteSelecionado;
        private Button btn_CriarRemessa;
        private Button btn_SelecionarRemessa;
    }
}