namespace TelaDeRemessas
{
    partial class SelecionarCliente
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
            cb_ListaClientes = new ComboBox();
            btn_Selecionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(188, 24);
            label1.TabIndex = 0;
            label1.Text = "Selecione o cliente";
            label1.UseWaitCursor = true;
            // 
            // cb_ListaClientes
            // 
            cb_ListaClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ListaClientes.FormattingEnabled = true;
            cb_ListaClientes.Location = new Point(27, 87);
            cb_ListaClientes.MaxDropDownItems = 20;
            cb_ListaClientes.Name = "cb_ListaClientes";
            cb_ListaClientes.Size = new Size(188, 23);
            cb_ListaClientes.TabIndex = 1;
            // 
            // btn_Selecionar
            // 
            btn_Selecionar.Location = new Point(27, 137);
            btn_Selecionar.Name = "btn_Selecionar";
            btn_Selecionar.Size = new Size(75, 23);
            btn_Selecionar.TabIndex = 2;
            btn_Selecionar.Text = "Selecionar";
            btn_Selecionar.UseVisualStyleBackColor = true;
            btn_Selecionar.Click += btn_Selecionar_Click;
            // 
            // SelecionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 208);
            Controls.Add(btn_Selecionar);
            Controls.Add(cb_ListaClientes);
            Controls.Add(label1);
            Name = "SelecionarCliente";
            Text = "Selecionar o Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cb_ListaClientes;
        private Button btn_Selecionar;
    }
}