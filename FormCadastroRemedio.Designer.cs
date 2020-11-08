namespace SystemaPet
{
    partial class FormCadastroRemedio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroRemedio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewRemedio = new System.Windows.Forms.DataGridView();
            this.tipo_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_remedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIDRemedio = new System.Windows.Forms.TextBox();
            this.maskedTextBoxValidadeRemedio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AlterarRemedio = new System.Windows.Forms.Button();
            this.button_ExcluirRemedio = new System.Windows.Forms.Button();
            this.button_SalvarRemedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Peso = new System.Windows.Forms.Label();
            this.label_preco = new System.Windows.Forms.Label();
            this.label_Utilidade = new System.Windows.Forms.Label();
            this.label_Produto = new System.Windows.Forms.Label();
            this.libel_Nome_Remedio = new System.Windows.Forms.Label();
            this.textBox_QuantidadeRemedio = new System.Windows.Forms.TextBox();
            this.textBox_PrecoRemedio = new System.Windows.Forms.TextBox();
            this.textBox_PesoRemedio = new System.Windows.Forms.TextBox();
            this.textBox_UtilidadeRemedio = new System.Windows.Forms.TextBox();
            this.textBox_ProdutoRemedio = new System.Windows.Forms.TextBox();
            this.textBox_NomeRemedio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemedio)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridViewRemedio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 599);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewRemedio
            // 
            this.dataGridViewRemedio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewRemedio.AllowUserToAddRows = false;
            this.dataGridViewRemedio.AllowUserToDeleteRows = false;
            this.dataGridViewRemedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_animal,
            this.nome_remedio,
            this.utilidade,
            this.peso,
            this.preco,
            this.validade});
            this.dataGridViewRemedio.Location = new System.Drawing.Point(0, 345);
            this.dataGridViewRemedio.Name = "dataGridViewRemedio";
            this.dataGridViewRemedio.ReadOnly = true;
            this.dataGridViewRemedio.Size = new System.Drawing.Size(558, 254);
            this.dataGridViewRemedio.TabIndex = 21;
            this.dataGridViewRemedio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRemedio_CellClick);
            // 
            // tipo_animal
            // 
            this.tipo_animal.DataPropertyName = "tipo_animal";
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_animal.DefaultCellStyle = dataGridViewCellStyle31;
            this.tipo_animal.HeaderText = "ANIMAL";
            this.tipo_animal.Name = "tipo_animal";
            this.tipo_animal.ReadOnly = true;
            // 
            // nome_remedio
            // 
            this.nome_remedio.DataPropertyName = "nome_remedio";
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.nome_remedio.DefaultCellStyle = dataGridViewCellStyle32;
            this.nome_remedio.HeaderText = "ALIMENTO";
            this.nome_remedio.Name = "nome_remedio";
            this.nome_remedio.ReadOnly = true;
            this.nome_remedio.Width = 150;
            // 
            // utilidade
            // 
            this.utilidade.DataPropertyName = "utilidade";
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.utilidade.DefaultCellStyle = dataGridViewCellStyle33;
            this.utilidade.HeaderText = "UTILIDADE";
            this.utilidade.Name = "utilidade";
            this.utilidade.ReadOnly = true;
            this.utilidade.Width = 120;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.peso.DefaultCellStyle = dataGridViewCellStyle34;
            this.peso.HeaderText = "PESO";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 50;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.preco.DefaultCellStyle = dataGridViewCellStyle35;
            this.preco.HeaderText = "PREÇO";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 50;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "validade";
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.validade.DefaultCellStyle = dataGridViewCellStyle36;
            this.validade.HeaderText = "VAL";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            this.validade.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxIDRemedio);
            this.panel2.Controls.Add(this.maskedTextBoxValidadeRemedio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_AlterarRemedio);
            this.panel2.Controls.Add(this.button_ExcluirRemedio);
            this.panel2.Controls.Add(this.button_SalvarRemedio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label_Peso);
            this.panel2.Controls.Add(this.label_preco);
            this.panel2.Controls.Add(this.label_Utilidade);
            this.panel2.Controls.Add(this.label_Produto);
            this.panel2.Controls.Add(this.libel_Nome_Remedio);
            this.panel2.Controls.Add(this.textBox_QuantidadeRemedio);
            this.panel2.Controls.Add(this.textBox_PrecoRemedio);
            this.panel2.Controls.Add(this.textBox_PesoRemedio);
            this.panel2.Controls.Add(this.textBox_UtilidadeRemedio);
            this.panel2.Controls.Add(this.textBox_ProdutoRemedio);
            this.panel2.Controls.Add(this.textBox_NomeRemedio);
            this.panel2.Location = new System.Drawing.Point(27, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 245);
            this.panel2.TabIndex = 1;
            // 
            // textBoxIDRemedio
            // 
            this.textBoxIDRemedio.Enabled = false;
            this.textBoxIDRemedio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDRemedio.Location = new System.Drawing.Point(7, 212);
            this.textBoxIDRemedio.Multiline = true;
            this.textBoxIDRemedio.Name = "textBoxIDRemedio";
            this.textBoxIDRemedio.Size = new System.Drawing.Size(68, 23);
            this.textBoxIDRemedio.TabIndex = 19;
            // 
            // maskedTextBoxValidadeRemedio
            // 
            this.maskedTextBoxValidadeRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxValidadeRemedio.Location = new System.Drawing.Point(408, 123);
            this.maskedTextBoxValidadeRemedio.Mask = "00/0000";
            this.maskedTextBoxValidadeRemedio.Name = "maskedTextBoxValidadeRemedio";
            this.maskedTextBoxValidadeRemedio.Size = new System.Drawing.Size(70, 26);
            this.maskedTextBoxValidadeRemedio.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(317, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Validade";
            // 
            // button_AlterarRemedio
            // 
            this.button_AlterarRemedio.Image = ((System.Drawing.Image)(resources.GetObject("button_AlterarRemedio.Image")));
            this.button_AlterarRemedio.Location = new System.Drawing.Point(408, 170);
            this.button_AlterarRemedio.Name = "button_AlterarRemedio";
            this.button_AlterarRemedio.Size = new System.Drawing.Size(66, 65);
            this.button_AlterarRemedio.TabIndex = 15;
            this.button_AlterarRemedio.UseVisualStyleBackColor = true;
            this.button_AlterarRemedio.Click += new System.EventHandler(this.button_AlterarRemedio_Click);
            // 
            // button_ExcluirRemedio
            // 
            this.button_ExcluirRemedio.Image = ((System.Drawing.Image)(resources.GetObject("button_ExcluirRemedio.Image")));
            this.button_ExcluirRemedio.Location = new System.Drawing.Point(321, 170);
            this.button_ExcluirRemedio.Name = "button_ExcluirRemedio";
            this.button_ExcluirRemedio.Size = new System.Drawing.Size(66, 65);
            this.button_ExcluirRemedio.TabIndex = 14;
            this.button_ExcluirRemedio.UseVisualStyleBackColor = true;
            this.button_ExcluirRemedio.Click += new System.EventHandler(this.button_ExcluirRemedio_Click);
            // 
            // button_SalvarRemedio
            // 
            this.button_SalvarRemedio.Image = ((System.Drawing.Image)(resources.GetObject("button_SalvarRemedio.Image")));
            this.button_SalvarRemedio.Location = new System.Drawing.Point(238, 170);
            this.button_SalvarRemedio.Name = "button_SalvarRemedio";
            this.button_SalvarRemedio.Size = new System.Drawing.Size(66, 65);
            this.button_SalvarRemedio.TabIndex = 13;
            this.button_SalvarRemedio.UseVisualStyleBackColor = true;
            this.button_SalvarRemedio.Click += new System.EventHandler(this.button_SalvarRemedio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(292, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantidade";
            // 
            // label_Peso
            // 
            this.label_Peso.AutoSize = true;
            this.label_Peso.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Peso.ForeColor = System.Drawing.Color.Yellow;
            this.label_Peso.Location = new System.Drawing.Point(155, 83);
            this.label_Peso.Name = "label_Peso";
            this.label_Peso.Size = new System.Drawing.Size(52, 22);
            this.label_Peso.TabIndex = 10;
            this.label_Peso.Text = "Peso";
            // 
            // label_preco
            // 
            this.label_preco.AutoSize = true;
            this.label_preco.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco.ForeColor = System.Drawing.Color.Yellow;
            this.label_preco.Location = new System.Drawing.Point(14, 82);
            this.label_preco.Name = "label_preco";
            this.label_preco.Size = new System.Drawing.Size(61, 22);
            this.label_preco.TabIndex = 9;
            this.label_preco.Text = "Preço";
            // 
            // label_Utilidade
            // 
            this.label_Utilidade.AutoSize = true;
            this.label_Utilidade.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Utilidade.ForeColor = System.Drawing.Color.Yellow;
            this.label_Utilidade.Location = new System.Drawing.Point(14, 51);
            this.label_Utilidade.Name = "label_Utilidade";
            this.label_Utilidade.Size = new System.Drawing.Size(90, 22);
            this.label_Utilidade.TabIndex = 8;
            this.label_Utilidade.Text = "Utilidade";
            // 
            // label_Produto
            // 
            this.label_Produto.AutoSize = true;
            this.label_Produto.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Produto.ForeColor = System.Drawing.Color.Yellow;
            this.label_Produto.Location = new System.Drawing.Point(208, 16);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(82, 22);
            this.label_Produto.TabIndex = 7;
            this.label_Produto.Text = "Produto";
            // 
            // libel_Nome_Remedio
            // 
            this.libel_Nome_Remedio.AutoSize = true;
            this.libel_Nome_Remedio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libel_Nome_Remedio.ForeColor = System.Drawing.Color.Yellow;
            this.libel_Nome_Remedio.Location = new System.Drawing.Point(14, 16);
            this.libel_Nome_Remedio.Name = "libel_Nome_Remedio";
            this.libel_Nome_Remedio.Size = new System.Drawing.Size(72, 22);
            this.libel_Nome_Remedio.TabIndex = 6;
            this.libel_Nome_Remedio.Text = "Animal";
            // 
            // textBox_QuantidadeRemedio
            // 
            this.textBox_QuantidadeRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuantidadeRemedio.Location = new System.Drawing.Point(408, 84);
            this.textBox_QuantidadeRemedio.Multiline = true;
            this.textBox_QuantidadeRemedio.Name = "textBox_QuantidadeRemedio";
            this.textBox_QuantidadeRemedio.Size = new System.Drawing.Size(70, 26);
            this.textBox_QuantidadeRemedio.TabIndex = 5;
            this.textBox_QuantidadeRemedio.TextChanged += new System.EventHandler(this.textBox_QuantidadeRemedio_TextChanged);
            // 
            // textBox_PrecoRemedio
            // 
            this.textBox_PrecoRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrecoRemedio.Location = new System.Drawing.Point(81, 82);
            this.textBox_PrecoRemedio.Multiline = true;
            this.textBox_PrecoRemedio.Name = "textBox_PrecoRemedio";
            this.textBox_PrecoRemedio.Size = new System.Drawing.Size(68, 23);
            this.textBox_PrecoRemedio.TabIndex = 4;
            this.textBox_PrecoRemedio.TextChanged += new System.EventHandler(this.textBox_PrecoRemedio_TextChanged);
            // 
            // textBox_PesoRemedio
            // 
            this.textBox_PesoRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesoRemedio.Location = new System.Drawing.Point(212, 83);
            this.textBox_PesoRemedio.Multiline = true;
            this.textBox_PesoRemedio.Name = "textBox_PesoRemedio";
            this.textBox_PesoRemedio.Size = new System.Drawing.Size(69, 23);
            this.textBox_PesoRemedio.TabIndex = 3;
            this.textBox_PesoRemedio.TextChanged += new System.EventHandler(this.textBox_PesoRemedio_TextChanged);
            // 
            // textBox_UtilidadeRemedio
            // 
            this.textBox_UtilidadeRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UtilidadeRemedio.Location = new System.Drawing.Point(110, 50);
            this.textBox_UtilidadeRemedio.Multiline = true;
            this.textBox_UtilidadeRemedio.Name = "textBox_UtilidadeRemedio";
            this.textBox_UtilidadeRemedio.Size = new System.Drawing.Size(368, 23);
            this.textBox_UtilidadeRemedio.TabIndex = 2;
            this.textBox_UtilidadeRemedio.TextChanged += new System.EventHandler(this.textBox_UtilidadeRemedio_TextChanged);
            // 
            // textBox_ProdutoRemedio
            // 
            this.textBox_ProdutoRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProdutoRemedio.Location = new System.Drawing.Point(296, 15);
            this.textBox_ProdutoRemedio.Multiline = true;
            this.textBox_ProdutoRemedio.Name = "textBox_ProdutoRemedio";
            this.textBox_ProdutoRemedio.Size = new System.Drawing.Size(182, 23);
            this.textBox_ProdutoRemedio.TabIndex = 1;
            this.textBox_ProdutoRemedio.TextChanged += new System.EventHandler(this.textBox_ProdutoRemedio_TextChanged);
            // 
            // textBox_NomeRemedio
            // 
            this.textBox_NomeRemedio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NomeRemedio.Location = new System.Drawing.Point(90, 15);
            this.textBox_NomeRemedio.Multiline = true;
            this.textBox_NomeRemedio.Name = "textBox_NomeRemedio";
            this.textBox_NomeRemedio.Size = new System.Drawing.Size(112, 23);
            this.textBox_NomeRemedio.TabIndex = 0;
            this.textBox_NomeRemedio.TextChanged += new System.EventHandler(this.textBox_NomeRemedio_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroRemedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 599);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastroRemedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroRemedio";
            this.Load += new System.EventHandler(this.FormCadastroRemedio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemedio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Peso;
        private System.Windows.Forms.Label label_preco;
        private System.Windows.Forms.Label label_Utilidade;
        private System.Windows.Forms.Label label_Produto;
        private System.Windows.Forms.Label libel_Nome_Remedio;
        private System.Windows.Forms.TextBox textBox_QuantidadeRemedio;
        private System.Windows.Forms.TextBox textBox_PrecoRemedio;
        private System.Windows.Forms.TextBox textBox_PesoRemedio;
        private System.Windows.Forms.TextBox textBox_UtilidadeRemedio;
        private System.Windows.Forms.TextBox textBox_ProdutoRemedio;
        private System.Windows.Forms.TextBox textBox_NomeRemedio;
        private System.Windows.Forms.Button button_ExcluirRemedio;
        private System.Windows.Forms.Button button_SalvarRemedio;
        private System.Windows.Forms.Button button_AlterarRemedio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValidadeRemedio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewRemedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_remedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.TextBox textBoxIDRemedio;
    }
}