namespace TelaDeRemessas
{
    partial class AdicionarRemessaEntrada
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
            dtg_Entrada = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacotesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDeBarrrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            perfilBindingSource = new BindingSource(components);
            btn_adicionarEntrada = new Button();
            txt_codigoEntrada = new TextBox();
            btn_salvar = new Button();
            label1 = new Label();
            btn_removerPerfil = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Entrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtg_Entrada
            // 
            dtg_Entrada.AllowUserToAddRows = false;
            dtg_Entrada.AllowUserToDeleteRows = false;
            dtg_Entrada.AutoGenerateColumns = false;
            dtg_Entrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Entrada.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, pacotesDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, codigoDeBarrrasDataGridViewTextBoxColumn, barrasDataGridViewTextBoxColumn });
            dtg_Entrada.DataSource = perfilBindingSource;
            dtg_Entrada.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtg_Entrada.Location = new Point(12, 112);
            dtg_Entrada.Name = "dtg_Entrada";
            dtg_Entrada.ReadOnly = true;
            dtg_Entrada.RowTemplate.Height = 25;
            dtg_Entrada.RowTemplate.ReadOnly = true;
            dtg_Entrada.Size = new Size(672, 247);
            dtg_Entrada.TabIndex = 1;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacotesDataGridViewTextBoxColumn
            // 
            pacotesDataGridViewTextBoxColumn.DataPropertyName = "Pacotes";
            pacotesDataGridViewTextBoxColumn.HeaderText = "Pacotes";
            pacotesDataGridViewTextBoxColumn.Name = "pacotesDataGridViewTextBoxColumn";
            pacotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDeBarrrasDataGridViewTextBoxColumn
            // 
            codigoDeBarrrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarrras";
            codigoDeBarrrasDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarrras";
            codigoDeBarrrasDataGridViewTextBoxColumn.Name = "codigoDeBarrrasDataGridViewTextBoxColumn";
            codigoDeBarrrasDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDeBarrrasDataGridViewTextBoxColumn.Width = 150;
            // 
            // barrasDataGridViewTextBoxColumn
            // 
            barrasDataGridViewTextBoxColumn.DataPropertyName = "Barras";
            barrasDataGridViewTextBoxColumn.HeaderText = "Barras";
            barrasDataGridViewTextBoxColumn.Name = "barrasDataGridViewTextBoxColumn";
            barrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perfilBindingSource
            // 
            perfilBindingSource.DataSource = typeof(ControladoraDeRemessa.Classes.Perfil);
            // 
            // btn_adicionarEntrada
            // 
            btn_adicionarEntrada.Location = new Point(12, 83);
            btn_adicionarEntrada.Name = "btn_adicionarEntrada";
            btn_adicionarEntrada.Size = new Size(114, 23);
            btn_adicionarEntrada.TabIndex = 1;
            btn_adicionarEntrada.Text = "Adicionar Perfil";
            btn_adicionarEntrada.UseVisualStyleBackColor = true;
            btn_adicionarEntrada.Click += btn_adicionarEntrada_Click;
            // 
            // txt_codigoEntrada
            // 
            txt_codigoEntrada.Location = new Point(12, 54);
            txt_codigoEntrada.Name = "txt_codigoEntrada";
            txt_codigoEntrada.Size = new Size(143, 23);
            txt_codigoEntrada.TabIndex = 2;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(12, 365);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(88, 24);
            btn_salvar.TabIndex = 3;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvarEntrada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(595, 24);
            label1.TabIndex = 4;
            label1.Text = "Digite o código do Perfil para adicionar na remessa de entrada";
            // 
            // btn_removerPerfil
            // 
            btn_removerPerfil.Location = new Point(132, 83);
            btn_removerPerfil.Name = "btn_removerPerfil";
            btn_removerPerfil.Size = new Size(104, 23);
            btn_removerPerfil.TabIndex = 5;
            btn_removerPerfil.Text = "Remover Perrfil";
            btn_removerPerfil.UseVisualStyleBackColor = true;
            btn_removerPerfil.Click += btn_removerPerfil_Click;
            // 
            // AdicionarRemessaEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 411);
            Controls.Add(btn_removerPerfil);
            Controls.Add(label1);
            Controls.Add(btn_salvar);
            Controls.Add(txt_codigoEntrada);
            Controls.Add(btn_adicionarEntrada);
            Controls.Add(dtg_Entrada);
            Name = "AdicionarRemessaEntrada";
            Text = "AdicionarRemessaEntrada";
            ((System.ComponentModel.ISupportInitialize)dtg_Entrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource perfilBindingSource;
        private Button btn_adicionarEntrada;
        private TextBox txt_codigoEntrada;
        private Button btn_salvar;
        private Label label1;
        public DataGridView dtg_Entrada;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pacotesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDeBarrrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barrasDataGridViewTextBoxColumn;
        private Button btn_removerPerfil;
    }
}