namespace TelaDeRemessas
{
    partial class CadastrarRemessa
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
            txtb_Remessa = new TextBox();
            btn_Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(273, 24);
            label1.TabIndex = 0;
            label1.Text = "Digite o numero da remessa";
            // 
            // txtb_Remessa
            // 
            txtb_Remessa.Location = new Point(12, 59);
            txtb_Remessa.Name = "txtb_Remessa";
            txtb_Remessa.Size = new Size(100, 23);
            txtb_Remessa.TabIndex = 1;
            txtb_Remessa.KeyPress += txtb_Remessa_KeyPress;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(12, 98);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(85, 24);
            btn_Salvar.TabIndex = 2;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_click;
            // 
            // CriarRemessa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 152);
            Controls.Add(btn_Salvar);
            Controls.Add(txtb_Remessa);
            Controls.Add(label1);
            Name = "CriarRemessa";
            Text = "CriarRemessa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtb_Remessa;
        private Button btn_Salvar;
    }
}