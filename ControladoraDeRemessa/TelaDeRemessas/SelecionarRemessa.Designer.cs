namespace TelaDeRemessas
{
    partial class SelecionarRemessa
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
            btn_Selecionar = new Button();
            cb_ListaDeRemessa = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(484, 24);
            label1.TabIndex = 0;
            label1.Text = "Digite o numero da remessa que deseja selecionar";
            // 
            // btn_Selecionar
            // 
            btn_Selecionar.Location = new Point(12, 110);
            btn_Selecionar.Name = "btn_Selecionar";
            btn_Selecionar.Size = new Size(102, 32);
            btn_Selecionar.TabIndex = 2;
            btn_Selecionar.Text = "Selecionar";
            btn_Selecionar.UseVisualStyleBackColor = true;
            btn_Selecionar.Click += btn_Selecionar_Click;
            // 
            // cb_ListaDeRemessa
            // 
            cb_ListaDeRemessa.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ListaDeRemessa.FormattingEnabled = true;
            cb_ListaDeRemessa.Location = new Point(12, 65);
            cb_ListaDeRemessa.Name = "cb_ListaDeRemessa";
            cb_ListaDeRemessa.Size = new Size(130, 23);
            cb_ListaDeRemessa.TabIndex = 3;
            // 
            // SelecionarRemessa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 177);
            Controls.Add(cb_ListaDeRemessa);
            Controls.Add(btn_Selecionar);
            Controls.Add(label1);
            Name = "SelecionarRemessa";
            Text = "SelecionarRemessa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Selecionar;
        private ComboBox cb_ListaDeRemessa;
    }
}