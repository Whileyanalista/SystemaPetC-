namespace SystemaPet
{
    partial class FormCadastroAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAlimento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_AlterarAlimento = new System.Windows.Forms.Button();
            this.button_excluirAlimento = new System.Windows.Forms.Button();
            this.button_salvarAlimento = new System.Windows.Forms.Button();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.label_Peso = new System.Windows.Forms.Label();
            this.label_preco = new System.Windows.Forms.Label();
            this.label_Utilidade = new System.Windows.Forms.Label();
            this.label_Produto = new System.Windows.Forms.Label();
            this.libel_Nome_Remedio = new System.Windows.Forms.Label();
            this.textBox_QuantidadeAlomento = new System.Windows.Forms.TextBox();
            this.textBox_PrecoAlimento = new System.Windows.Forms.TextBox();
            this.textBox_PesoAlimento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_UtilidadeAlimento = new System.Windows.Forms.TextBox();
            this.textBox_ProdutoAlimento = new System.Windows.Forms.TextBox();
            this.textBox_NomeAlimento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIDAlimento = new System.Windows.Forms.TextBox();
            this.maskedTextBoxValidadeAlimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAlimento = new System.Windows.Forms.DataGridView();
            this.tipo_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlimento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AlterarAlimento
            // 
            this.button_AlterarAlimento.Image = ((System.Drawing.Image)(resources.GetObject("button_AlterarAlimento.Image")));
            this.button_AlterarAlimento.Location = new System.Drawing.Point(405, 157);
            this.button_AlterarAlimento.Name = "button_AlterarAlimento";
            this.button_AlterarAlimento.Size = new System.Drawing.Size(66, 65);
            this.button_AlterarAlimento.TabIndex = 15;
            this.button_AlterarAlimento.UseVisualStyleBackColor = true;
            this.button_AlterarAlimento.Click += new System.EventHandler(this.button_AlterarAlimento_Click);
            // 
            // button_excluirAlimento
            // 
            this.button_excluirAlimento.Image = ((System.Drawing.Image)(resources.GetObject("button_excluirAlimento.Image")));
            this.button_excluirAlimento.Location = new System.Drawing.Point(324, 157);
            this.button_excluirAlimento.Name = "button_excluirAlimento";
            this.button_excluirAlimento.Size = new System.Drawing.Size(66, 65);
            this.button_excluirAlimento.TabIndex = 14;
            this.button_excluirAlimento.UseVisualStyleBackColor = true;
            this.button_excluirAlimento.Click += new System.EventHandler(this.button_excluirAlimento_Click);
            // 
            // button_salvarAlimento
            // 
            this.button_salvarAlimento.Image = ((System.Drawing.Image)(resources.GetObject("button_salvarAlimento.Image")));
            this.button_salvarAlimento.Location = new System.Drawing.Point(243, 157);
            this.button_salvarAlimento.Name = "button_salvarAlimento";
            this.button_salvarAlimento.Size = new System.Drawing.Size(66, 65);
            this.button_salvarAlimento.TabIndex = 13;
            this.button_salvarAlimento.UseVisualStyleBackColor = true;
            this.button_salvarAlimento.Click += new System.EventHandler(this.button_salvarAlimento_Click);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.ForeColor = System.Drawing.Color.Yellow;
            this.labelQuantidade.Location = new System.Drawing.Point(287, 81);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(110, 22);
            this.labelQuantidade.TabIndex = 11;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // label_Peso
            // 
            this.label_Peso.AutoSize = true;
            this.label_Peso.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Peso.ForeColor = System.Drawing.Color.Yellow;
            this.label_Peso.Location = new System.Drawing.Point(154, 80);
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
            this.label_preco.Location = new System.Drawing.Point(13, 80);
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
            this.label_Utilidade.Location = new System.Drawing.Point(13, 46);
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
            this.label_Produto.Location = new System.Drawing.Point(223, 12);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(86, 22);
            this.label_Produto.TabIndex = 7;
            this.label_Produto.Text = " Produto";
            // 
            // libel_Nome_Remedio
            // 
            this.libel_Nome_Remedio.AutoSize = true;
            this.libel_Nome_Remedio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libel_Nome_Remedio.ForeColor = System.Drawing.Color.Yellow;
            this.libel_Nome_Remedio.Location = new System.Drawing.Point(13, 12);
            this.libel_Nome_Remedio.Name = "libel_Nome_Remedio";
            this.libel_Nome_Remedio.Size = new System.Drawing.Size(72, 22);
            this.libel_Nome_Remedio.TabIndex = 6;
            this.libel_Nome_Remedio.Text = "Animal";
            // 
            // textBox_QuantidadeAlomento
            // 
            this.textBox_QuantidadeAlomento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuantidadeAlomento.Location = new System.Drawing.Point(403, 81);
            this.textBox_QuantidadeAlomento.Multiline = true;
            this.textBox_QuantidadeAlomento.Name = "textBox_QuantidadeAlomento";
            this.textBox_QuantidadeAlomento.Size = new System.Drawing.Size(67, 23);
            this.textBox_QuantidadeAlomento.TabIndex = 5;
            this.textBox_QuantidadeAlomento.TextChanged += new System.EventHandler(this.textBox_QuantidadeAlomento_TextChanged);
            // 
            // textBox_PrecoAlimento
            // 
            this.textBox_PrecoAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrecoAlimento.Location = new System.Drawing.Point(80, 79);
            this.textBox_PrecoAlimento.Multiline = true;
            this.textBox_PrecoAlimento.Name = "textBox_PrecoAlimento";
            this.textBox_PrecoAlimento.Size = new System.Drawing.Size(68, 23);
            this.textBox_PrecoAlimento.TabIndex = 4;
            this.textBox_PrecoAlimento.TextChanged += new System.EventHandler(this.textBox_PrecoAlimento_TextChanged);
            // 
            // textBox_PesoAlimento
            // 
            this.textBox_PesoAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesoAlimento.Location = new System.Drawing.Point(212, 80);
            this.textBox_PesoAlimento.Multiline = true;
            this.textBox_PesoAlimento.Name = "textBox_PesoAlimento";
            this.textBox_PesoAlimento.Size = new System.Drawing.Size(69, 23);
            this.textBox_PesoAlimento.TabIndex = 3;
            this.textBox_PesoAlimento.TextChanged += new System.EventHandler(this.textBox_PesoAlimento_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_UtilidadeAlimento
            // 
            this.textBox_UtilidadeAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UtilidadeAlimento.Location = new System.Drawing.Point(109, 45);
            this.textBox_UtilidadeAlimento.Multiline = true;
            this.textBox_UtilidadeAlimento.Name = "textBox_UtilidadeAlimento";
            this.textBox_UtilidadeAlimento.Size = new System.Drawing.Size(362, 23);
            this.textBox_UtilidadeAlimento.TabIndex = 2;
            this.textBox_UtilidadeAlimento.TextChanged += new System.EventHandler(this.textBox_UtilidadeAlimento_TextChanged);
            // 
            // textBox_ProdutoAlimento
            // 
            this.textBox_ProdutoAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProdutoAlimento.Location = new System.Drawing.Point(315, 11);
            this.textBox_ProdutoAlimento.Multiline = true;
            this.textBox_ProdutoAlimento.Name = "textBox_ProdutoAlimento";
            this.textBox_ProdutoAlimento.Size = new System.Drawing.Size(156, 23);
            this.textBox_ProdutoAlimento.TabIndex = 1;
            this.textBox_ProdutoAlimento.TextChanged += new System.EventHandler(this.textBox_ProdutoAlimento_TextChanged);
            // 
            // textBox_NomeAlimento
            // 
            this.textBox_NomeAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NomeAlimento.Location = new System.Drawing.Point(91, 11);
            this.textBox_NomeAlimento.Multiline = true;
            this.textBox_NomeAlimento.Name = "textBox_NomeAlimento";
            this.textBox_NomeAlimento.Size = new System.Drawing.Size(121, 23);
            this.textBox_NomeAlimento.TabIndex = 0;
            this.textBox_NomeAlimento.TextChanged += new System.EventHandler(this.textBox_NomeAlimento_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxIDAlimento);
            this.panel2.Controls.Add(this.maskedTextBoxValidadeAlimento);
            this.panel2.Controls.Add(this.button_AlterarAlimento);
            this.panel2.Controls.Add(this.button_excluirAlimento);
            this.panel2.Controls.Add(this.button_salvarAlimento);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelQuantidade);
            this.panel2.Controls.Add(this.label_Peso);
            this.panel2.Controls.Add(this.label_preco);
            this.panel2.Controls.Add(this.label_Utilidade);
            this.panel2.Controls.Add(this.label_Produto);
            this.panel2.Controls.Add(this.libel_Nome_Remedio);
            this.panel2.Controls.Add(this.textBox_QuantidadeAlomento);
            this.panel2.Controls.Add(this.textBox_PrecoAlimento);
            this.panel2.Controls.Add(this.textBox_PesoAlimento);
            this.panel2.Controls.Add(this.textBox_UtilidadeAlimento);
            this.panel2.Controls.Add(this.textBox_ProdutoAlimento);
            this.panel2.Controls.Add(this.textBox_NomeAlimento);
            this.panel2.Location = new System.Drawing.Point(40, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 236);
            this.panel2.TabIndex = 4;
            // 
            // textBoxIDAlimento
            // 
            this.textBoxIDAlimento.Enabled = false;
            this.textBoxIDAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDAlimento.Location = new System.Drawing.Point(17, 199);
            this.textBoxIDAlimento.Multiline = true;
            this.textBoxIDAlimento.Name = "textBoxIDAlimento";
            this.textBoxIDAlimento.Size = new System.Drawing.Size(68, 23);
            this.textBoxIDAlimento.TabIndex = 17;
            // 
            // maskedTextBoxValidadeAlimento
            // 
            this.maskedTextBoxValidadeAlimento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxValidadeAlimento.Location = new System.Drawing.Point(403, 114);
            this.maskedTextBoxValidadeAlimento.Mask = "00/0000";
            this.maskedTextBoxValidadeAlimento.Name = "maskedTextBoxValidadeAlimento";
            this.maskedTextBoxValidadeAlimento.Size = new System.Drawing.Size(65, 26);
            this.maskedTextBoxValidadeAlimento.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(305, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Validade";
            // 
            // dataGridViewAlimento
            // 
            this.dataGridViewAlimento.AllowUserToAddRows = false;
            this.dataGridViewAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_animal,
            this.nome_comida,
            this.utilidade,
            this.peso,
            this.preco,
            this.validade});
            this.dataGridViewAlimento.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewAlimento.Name = "dataGridViewAlimento";
            this.dataGridViewAlimento.Size = new System.Drawing.Size(563, 285);
            this.dataGridViewAlimento.TabIndex = 20;
            this.dataGridViewAlimento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlimento_CellClick);
            // 
            // tipo_animal
            // 
            this.tipo_animal.DataPropertyName = "tipo_animal";
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_animal.DefaultCellStyle = dataGridViewCellStyle31;
            this.tipo_animal.HeaderText = "ANIMAL";
            this.tipo_animal.Name = "tipo_animal";
            // 
            // nome_comida
            // 
            this.nome_comida.DataPropertyName = "nome_comida";
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.nome_comida.DefaultCellStyle = dataGridViewCellStyle32;
            this.nome_comida.HeaderText = "ALIMENTO";
            this.nome_comida.Name = "nome_comida";
            this.nome_comida.Width = 150;
            // 
            // utilidade
            // 
            this.utilidade.DataPropertyName = "utilidade";
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.utilidade.DefaultCellStyle = dataGridViewCellStyle33;
            this.utilidade.HeaderText = "UTILIDADE";
            this.utilidade.Name = "utilidade";
            this.utilidade.Width = 120;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.peso.DefaultCellStyle = dataGridViewCellStyle34;
            this.peso.HeaderText = "PESO";
            this.peso.Name = "peso";
            this.peso.Width = 50;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.preco.DefaultCellStyle = dataGridViewCellStyle35;
            this.preco.HeaderText = "PREÇO";
            this.preco.Name = "preco";
            this.preco.Width = 50;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "validade";
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.validade.DefaultCellStyle = dataGridViewCellStyle36;
            this.validade.HeaderText = "VAL";
            this.validade.Name = "validade";
            this.validade.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewAlimento);
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 278);
            this.panel1.TabIndex = 21;
            // 
            // FormCadastroAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCadastroAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroAlimento";
            this.Load += new System.EventHandler(this.FormCadastroAlimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlimento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AlterarAlimento;
        private System.Windows.Forms.Button button_excluirAlimento;
        private System.Windows.Forms.Button button_salvarAlimento;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label label_Peso;
        private System.Windows.Forms.Label label_preco;
        private System.Windows.Forms.Label label_Utilidade;
        private System.Windows.Forms.Label label_Produto;
        private System.Windows.Forms.Label libel_Nome_Remedio;
        private System.Windows.Forms.TextBox textBox_QuantidadeAlomento;
        private System.Windows.Forms.TextBox textBox_PrecoAlimento;
        private System.Windows.Forms.TextBox textBox_PesoAlimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_UtilidadeAlimento;
        private System.Windows.Forms.TextBox textBox_ProdutoAlimento;
        private System.Windows.Forms.TextBox textBox_NomeAlimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValidadeAlimento;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewAlimento;
        private System.Windows.Forms.TextBox textBoxIDAlimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
    }
}