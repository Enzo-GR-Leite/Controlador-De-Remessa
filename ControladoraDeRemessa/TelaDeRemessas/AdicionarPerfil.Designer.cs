namespace TelaDeRemessas
{
    partial class AdicionarPerfil
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtb_Nome = new TextBox();
            perfilBindingSource = new BindingSource(components);
            txtb_Codigo = new TextBox();
            txtb_Modelo = new TextBox();
            txtb_CodigoDeBarras = new TextBox();
            txtb_Barras = new TextBox();
            btn_adicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(225, 24);
            label1.TabIndex = 0;
            label1.Text = "Digite o Nome do Perfil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 148);
            label2.Name = "label2";
            label2.Size = new Size(156, 24);
            label2.TabIndex = 1;
            label2.Text = "Digite o Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 85);
            label3.Name = "label3";
            label3.Size = new Size(150, 24);
            label3.TabIndex = 2;
            label3.Text = "Digite o código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 210);
            label4.Name = "label4";
            label4.Size = new Size(245, 24);
            label4.TabIndex = 3;
            label4.Text = "Digite o código de barras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 273);
            label5.Name = "label5";
            label5.Size = new Size(391, 24);
            label5.TabIndex = 4;
            label5.Text = "Digite a quantidade de barras por pacote";
            // 
            // txtb_Nome
            // 
            txtb_Nome.DataBindings.Add(new Binding("Text", perfilBindingSource, "Nome", true));
            txtb_Nome.Location = new Point(48, 59);
            txtb_Nome.Name = "txtb_Nome";
            txtb_Nome.Size = new Size(225, 23);
            txtb_Nome.TabIndex = 6;
            // 
            // perfilBindingSource
            // 
            perfilBindingSource.DataSource = typeof(ControladoraDeRemessa.Classes.Perfil);
            // 
            // txtb_Codigo
            // 
            txtb_Codigo.DataBindings.Add(new Binding("Text", perfilBindingSource, "Codigo", true));
            txtb_Codigo.Location = new Point(48, 112);
            txtb_Codigo.Name = "txtb_Codigo";
            txtb_Codigo.Size = new Size(225, 23);
            txtb_Codigo.TabIndex = 7;
            // 
            // txtb_Modelo
            // 
            txtb_Modelo.DataBindings.Add(new Binding("Text", perfilBindingSource, "Modelo", true));
            txtb_Modelo.Location = new Point(48, 180);
            txtb_Modelo.Name = "txtb_Modelo";
            txtb_Modelo.Size = new Size(225, 23);
            txtb_Modelo.TabIndex = 8;
            // 
            // txtb_CodigoDeBarras
            // 
            txtb_CodigoDeBarras.DataBindings.Add(new Binding("Text", perfilBindingSource, "CodigoDeBarrras", true));
            txtb_CodigoDeBarras.Location = new Point(48, 241);
            txtb_CodigoDeBarras.Name = "txtb_CodigoDeBarras";
            txtb_CodigoDeBarras.Size = new Size(225, 23);
            txtb_CodigoDeBarras.TabIndex = 9;
            // 
            // txtb_Barras
            // 
            txtb_Barras.DataBindings.Add(new Binding("Text", perfilBindingSource, "Barras", true, DataSourceUpdateMode.OnValidation, null, "N0"));
            txtb_Barras.Location = new Point(48, 305);
            txtb_Barras.Name = "txtb_Barras";
            txtb_Barras.Size = new Size(74, 23);
            txtb_Barras.TabIndex = 10;
            txtb_Barras.KeyPress += txtb_Barras_KeyPress;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(44, 350);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(102, 31);
            btn_adicionar.TabIndex = 11;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // AdicionarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 476);
            Controls.Add(btn_adicionar);
            Controls.Add(txtb_Barras);
            Controls.Add(txtb_CodigoDeBarras);
            Controls.Add(txtb_Modelo);
            Controls.Add(txtb_Codigo);
            Controls.Add(txtb_Nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdicionarPerfil";
            Text = "AdicionarPerfil";
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtb_Nome;
        private TextBox txtb_Codigo;
        private TextBox txtb_Modelo;
        private TextBox txtb_CodigoDeBarras;
        private TextBox txtb_Barras;
        private BindingSource perfilBindingSource;
        private Button btn_adicionar;
    }
}