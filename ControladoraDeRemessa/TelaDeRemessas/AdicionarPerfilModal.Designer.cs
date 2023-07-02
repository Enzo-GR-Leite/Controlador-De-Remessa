namespace TelaDeRemessas
{
    partial class AdicionarPerfilModal
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
            btn_sim = new Button();
            btn_nao = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_sim
            // 
            btn_sim.Location = new Point(91, 161);
            btn_sim.Name = "btn_sim";
            btn_sim.Size = new Size(75, 23);
            btn_sim.TabIndex = 0;
            btn_sim.Text = "Sim";
            btn_sim.UseVisualStyleBackColor = true;
            btn_sim.Click += btn_sim_click;
            // 
            // btn_nao
            // 
            btn_nao.Location = new Point(292, 158);
            btn_nao.Name = "btn_nao";
            btn_nao.Size = new Size(84, 26);
            btn_nao.TabIndex = 1;
            btn_nao.Text = "Não";
            btn_nao.UseVisualStyleBackColor = true;
            btn_nao.Click += btn_nao_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 49);
            label1.Name = "label1";
            label1.Size = new Size(346, 27);
            label1.TabIndex = 2;
            label1.Text = "Perfil Adicionado com sucesso!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 97);
            label2.Name = "label2";
            label2.Size = new Size(285, 24);
            label2.TabIndex = 3;
            label2.Text = "Deseja Adicionar outro perfil?";
            // 
            // AdicionarPerfilModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 204);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_nao);
            Controls.Add(btn_sim);
            Name = "AdicionarPerfilModal";
            Text = "AdicionarPerfilModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sim;
        private Button btn_nao;
        private Label label1;
        private Label label2;
    }
}