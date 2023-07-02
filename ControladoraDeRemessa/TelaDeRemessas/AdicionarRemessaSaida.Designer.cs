namespace TelaDeRemessas
{
    partial class AdicionarRemessaSaida
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
            btn_adicionar = new Button();
            dtg_RemessaSaida = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacotesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDeBarrrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            perfilBindingSource = new BindingSource(components);
            dtg_remessaEntrada = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            txtb_codigo = new TextBox();
            btn_fecharRemessa = new Button();
            label1 = new Label();
            btn_remover = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_RemessaSaida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_remessaEntrada).BeginInit();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(12, 110);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 23);
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // dtg_RemessaSaida
            // 
            dtg_RemessaSaida.AllowUserToAddRows = false;
            dtg_RemessaSaida.AllowUserToDeleteRows = false;
            dtg_RemessaSaida.AutoGenerateColumns = false;
            dtg_RemessaSaida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_RemessaSaida.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, pacotesDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, codigoDeBarrrasDataGridViewTextBoxColumn, barrasDataGridViewTextBoxColumn });
            dtg_RemessaSaida.DataSource = perfilBindingSource;
            dtg_RemessaSaida.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtg_RemessaSaida.Location = new Point(12, 153);
            dtg_RemessaSaida.Name = "dtg_RemessaSaida";
            dtg_RemessaSaida.ReadOnly = true;
            dtg_RemessaSaida.RowTemplate.Height = 25;
            dtg_RemessaSaida.Size = new Size(643, 308);
            dtg_RemessaSaida.TabIndex = 1;
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
            // dtg_remessaEntrada
            // 
            dtg_remessaEntrada.AllowUserToAddRows = false;
            dtg_remessaEntrada.AllowUserToDeleteRows = false;
            dtg_remessaEntrada.AutoGenerateColumns = false;
            dtg_remessaEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_remessaEntrada.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtg_remessaEntrada.DataSource = perfilBindingSource;
            dtg_remessaEntrada.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtg_remessaEntrada.Location = new Point(732, 153);
            dtg_remessaEntrada.Name = "dtg_remessaEntrada";
            dtg_remessaEntrada.ReadOnly = true;
            dtg_remessaEntrada.RowTemplate.Height = 25;
            dtg_remessaEntrada.Size = new Size(643, 308);
            dtg_remessaEntrada.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Pacotes";
            dataGridViewTextBoxColumn2.HeaderText = "Pacotes";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn3.HeaderText = "Nome";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "CodigoDeBarrras";
            dataGridViewTextBoxColumn5.HeaderText = "CodigoDeBarrras";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Barras";
            dataGridViewTextBoxColumn6.HeaderText = "Barras";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // txtb_codigo
            // 
            txtb_codigo.Location = new Point(12, 66);
            txtb_codigo.Name = "txtb_codigo";
            txtb_codigo.Size = new Size(164, 23);
            txtb_codigo.TabIndex = 3;
            // 
            // btn_fecharRemessa
            // 
            btn_fecharRemessa.Enabled = false;
            btn_fecharRemessa.Location = new Point(12, 494);
            btn_fecharRemessa.Name = "btn_fecharRemessa";
            btn_fecharRemessa.Size = new Size(100, 23);
            btn_fecharRemessa.TabIndex = 4;
            btn_fecharRemessa.Text = "Fechar Remessa";
            btn_fecharRemessa.UseVisualStyleBackColor = true;
            btn_fecharRemessa.Click += btn_fecharRemessa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(433, 24);
            label1.TabIndex = 5;
            label1.Text = "Digite o código do Perfil que deseja adicionar";
            // 
            // btn_remover
            // 
            btn_remover.Location = new Point(93, 110);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(83, 23);
            btn_remover.TabIndex = 6;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // AdicionarRemessaSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 570);
            Controls.Add(btn_remover);
            Controls.Add(label1);
            Controls.Add(btn_fecharRemessa);
            Controls.Add(txtb_codigo);
            Controls.Add(dtg_remessaEntrada);
            Controls.Add(dtg_RemessaSaida);
            Controls.Add(btn_adicionar);
            Name = "AdicionarRemessaSaida";
            Text = "AdicionarFormulárioSaida";
            ((System.ComponentModel.ISupportInitialize)dtg_RemessaSaida).EndInit();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_remessaEntrada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private DataGridView dtg_RemessaSaida;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pacotesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDeBarrrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barrasDataGridViewTextBoxColumn;
        private BindingSource perfilBindingSource;
        private DataGridView dtg_remessaEntrada;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox txtb_codigo;
        private Button btn_fecharRemessa;
        private Label label1;
        private Button btn_remover;
    }
}