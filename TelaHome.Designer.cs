namespace SystemaPet
{
    partial class TelaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHome));
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_Pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewTelaHome = new System.Windows.Forms.DataGridView();
            this.nome_remedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemed = new System.Windows.Forms.Button();
            this.buttonAlimentos = new System.Windows.Forms.Button();
            this.buttonBrinquedos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelaHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Controls.Add(this.textBox_Pesquisa);
            this.panelHome.Controls.Add(this.dataGridViewTelaHome);
            this.panelHome.Controls.Add(this.buttonRemed);
            this.panelHome.Controls.Add(this.buttonAlimentos);
            this.panelHome.Controls.Add(this.buttonBrinquedos);
            this.panelHome.Controls.Add(this.panel1);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1093, 670);
            this.panelHome.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(925, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_Pesquisa
            // 
            this.textBox_Pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Pesquisa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pesquisa.Location = new System.Drawing.Point(11, 141);
            this.textBox_Pesquisa.Multiline = true;
            this.textBox_Pesquisa.Name = "textBox_Pesquisa";
            this.textBox_Pesquisa.Size = new System.Drawing.Size(658, 31);
            this.textBox_Pesquisa.TabIndex = 10;
            this.textBox_Pesquisa.Text = "PESQUISE UM PRODUTO";
            this.textBox_Pesquisa.Click += new System.EventHandler(this.textBox_Pesquisa_Click);           
            this.textBox_Pesquisa.Leave += new System.EventHandler(this.textBox_Pesquisa_Leave);
            // 
            // dataGridViewTelaHome
            // 
            this.dataGridViewTelaHome.AllowUserToOrderColumns = true;
            this.dataGridViewTelaHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelaHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_remedio,
            this.peso,
            this.preco,
            this.validade,
            this.quantidade});
            this.dataGridViewTelaHome.Location = new System.Drawing.Point(11, 178);
            this.dataGridViewTelaHome.Name = "dataGridViewTelaHome";
            this.dataGridViewTelaHome.Size = new System.Drawing.Size(1069, 479);
            this.dataGridViewTelaHome.TabIndex = 9;
            this.dataGridViewTelaHome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTelaHome_CellClick);
            // 
            // nome_remedio
            // 
            this.nome_remedio.DataPropertyName = "nome_remedio";
            this.nome_remedio.HeaderText = "Produto";
            this.nome_remedio.Name = "nome_remedio";
            this.nome_remedio.Width = 630;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // validade
            // 
            this.validade.DataPropertyName = "validade";
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // buttonRemed
            // 
            this.buttonRemed.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemed.Image")));
            this.buttonRemed.Location = new System.Drawing.Point(31, 11);
            this.buttonRemed.Name = "buttonRemed";
            this.buttonRemed.Size = new System.Drawing.Size(60, 75);
            this.buttonRemed.TabIndex = 6;
            this.buttonRemed.UseVisualStyleBackColor = false;
            this.buttonRemed.Click += new System.EventHandler(this.buttonRemed_Click);
            // 
            // buttonAlimentos
            // 
            this.buttonAlimentos.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlimentos.Image")));
            this.buttonAlimentos.Location = new System.Drawing.Point(201, 11);
            this.buttonAlimentos.Name = "buttonAlimentos";
            this.buttonAlimentos.Size = new System.Drawing.Size(62, 75);
            this.buttonAlimentos.TabIndex = 3;
            this.buttonAlimentos.UseVisualStyleBackColor = false;
            this.buttonAlimentos.Click += new System.EventHandler(this.buttonAlimentos_Click);
            // 
            // buttonBrinquedos
            // 
            this.buttonBrinquedos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrinquedos.Image")));
            this.buttonBrinquedos.Location = new System.Drawing.Point(115, 11);
            this.buttonBrinquedos.Name = "buttonBrinquedos";
            this.buttonBrinquedos.Size = new System.Drawing.Size(60, 75);
            this.buttonBrinquedos.TabIndex = 2;
            this.buttonBrinquedos.UseVisualStyleBackColor = false;
            this.buttonBrinquedos.Click += new System.EventHandler(this.buttonBrinquedos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonRelatorio);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 111);
            this.panel1.TabIndex = 7;
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("buttonRelatorio.Image")));
            this.buttonRelatorio.Location = new System.Drawing.Point(287, 12);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(60, 75);
            this.buttonRelatorio.TabIndex = 4;
            this.buttonRelatorio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1091, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TelaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 670);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "TelaHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaHome";
            this.Load += new System.EventHandler(this.TelaHome_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelaHome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.Button buttonRemedio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewTelaHome;
        private System.Windows.Forms.TextBox textBox_Pesquisa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_remedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        public System.Windows.Forms.Button buttonAlimentos;
        public System.Windows.Forms.Button buttonBrinquedos;
        public System.Windows.Forms.Button buttonRemed;
    }
}