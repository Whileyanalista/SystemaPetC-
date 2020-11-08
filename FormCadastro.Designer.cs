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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroRemedio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipo_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_remedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Peso = new System.Windows.Forms.Label();
            this.label_preco = new System.Windows.Forms.Label();
            this.label_Utilidade = new System.Windows.Forms.Label();
            this.label_Produto = new System.Windows.Forms.Label();
            this.libel_Nome_Remedio = new System.Windows.Forms.Label();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.textBox_Preco = new System.Windows.Forms.TextBox();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.textBox_Utilidade = new System.Windows.Forms.TextBox();
            this.textBox_Produto = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_animal,
            this.nome_remedio,
            this.utilidade,
            this.peso,
            this.preco,
            this.quantidade});
            this.dataGridView1.Location = new System.Drawing.Point(3, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // tipo_animal
            // 
            this.tipo_animal.HeaderText = "Animal";
            this.tipo_animal.Name = "tipo_animal";
            // 
            // nome_remedio
            // 
            this.nome_remedio.HeaderText = "Remedio";
            this.nome_remedio.Name = "nome_remedio";
            this.nome_remedio.Width = 115;
            // 
            // utilidade
            // 
            this.utilidade.HeaderText = "Utilidade";
            this.utilidade.Name = "utilidade";
            this.utilidade.Width = 107;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.Width = 50;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.Width = 50;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_Alterar);
            this.panel2.Controls.Add(this.button_excluir);
            this.panel2.Controls.Add(this.button_salvar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label_Peso);
            this.panel2.Controls.Add(this.label_preco);
            this.panel2.Controls.Add(this.label_Utilidade);
            this.panel2.Controls.Add(this.label_Produto);
            this.panel2.Controls.Add(this.libel_Nome_Remedio);
            this.panel2.Controls.Add(this.textBox_Quantidade);
            this.panel2.Controls.Add(this.textBox_Preco);
            this.panel2.Controls.Add(this.textBox_Peso);
            this.panel2.Controls.Add(this.textBox_Utilidade);
            this.panel2.Controls.Add(this.textBox_Produto);
            this.panel2.Controls.Add(this.textBox_Nome);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 261);
            this.panel2.TabIndex = 1;
            // 
            // button_Alterar
            // 
            this.button_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("button_Alterar.Image")));
            this.button_Alterar.Location = new System.Drawing.Point(405, 191);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(66, 65);
            this.button_Alterar.TabIndex = 15;
            this.button_Alterar.UseVisualStyleBackColor = true;
            // 
            // button_excluir
            // 
            this.button_excluir.Image = ((System.Drawing.Image)(resources.GetObject("button_excluir.Image")));
            this.button_excluir.Location = new System.Drawing.Point(324, 191);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(66, 65);
            this.button_excluir.TabIndex = 14;
            this.button_excluir.UseVisualStyleBackColor = true;
            // 
            // button_salvar
            // 
            this.button_salvar.Image = ((System.Drawing.Image)(resources.GetObject("button_salvar.Image")));
            this.button_salvar.Location = new System.Drawing.Point(243, 191);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(66, 65);
            this.button_salvar.TabIndex = 13;
            this.button_salvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(297, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantidade";
            // 
            // label_Peso
            // 
            this.label_Peso.AutoSize = true;
            this.label_Peso.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Peso.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_Peso.Location = new System.Drawing.Point(161, 136);
            this.label_Peso.Name = "label_Peso";
            this.label_Peso.Size = new System.Drawing.Size(58, 23);
            this.label_Peso.TabIndex = 10;
            this.label_Peso.Text = "Peso";
            // 
            // label_preco
            // 
            this.label_preco.AutoSize = true;
            this.label_preco.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_preco.Location = new System.Drawing.Point(13, 136);
            this.label_preco.Name = "label_preco";
            this.label_preco.Size = new System.Drawing.Size(72, 23);
            this.label_preco.TabIndex = 9;
            this.label_preco.Text = "Preço";
            // 
            // label_Utilidade
            // 
            this.label_Utilidade.AutoSize = true;
            this.label_Utilidade.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Utilidade.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_Utilidade.Location = new System.Drawing.Point(13, 99);
            this.label_Utilidade.Name = "label_Utilidade";
            this.label_Utilidade.Size = new System.Drawing.Size(111, 23);
            this.label_Utilidade.TabIndex = 8;
            this.label_Utilidade.Text = "Utilidade";
            // 
            // label_Produto
            // 
            this.label_Produto.AutoSize = true;
            this.label_Produto.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Produto.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_Produto.Location = new System.Drawing.Point(13, 64);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(192, 23);
            this.label_Produto.TabIndex = 7;
            this.label_Produto.Text = "Nome do Produto";
            // 
            // libel_Nome_Remedio
            // 
            this.libel_Nome_Remedio.AutoSize = true;
            this.libel_Nome_Remedio.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libel_Nome_Remedio.ForeColor = System.Drawing.Color.SteelBlue;
            this.libel_Nome_Remedio.Location = new System.Drawing.Point(13, 25);
            this.libel_Nome_Remedio.Name = "libel_Nome_Remedio";
            this.libel_Nome_Remedio.Size = new System.Drawing.Size(166, 23);
            this.libel_Nome_Remedio.TabIndex = 6;
            this.libel_Nome_Remedio.Text = "Nome do Animal";
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Quantidade.Location = new System.Drawing.Point(435, 136);
            this.textBox_Quantidade.Multiline = true;
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(35, 26);
            this.textBox_Quantidade.TabIndex = 5;
            // 
            // textBox_Preco
            // 
            this.textBox_Preco.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Preco.Location = new System.Drawing.Point(89, 136);
            this.textBox_Preco.Multiline = true;
            this.textBox_Preco.Name = "textBox_Preco";
            this.textBox_Preco.Size = new System.Drawing.Size(68, 23);
            this.textBox_Preco.TabIndex = 4;
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Peso.Location = new System.Drawing.Point(224, 136);
            this.textBox_Peso.Multiline = true;
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.Size = new System.Drawing.Size(69, 23);
            this.textBox_Peso.TabIndex = 3;
            // 
            // textBox_Utilidade
            // 
            this.textBox_Utilidade.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Utilidade.Location = new System.Drawing.Point(130, 99);
            this.textBox_Utilidade.Multiline = true;
            this.textBox_Utilidade.Name = "textBox_Utilidade";
            this.textBox_Utilidade.Size = new System.Drawing.Size(340, 23);
            this.textBox_Utilidade.TabIndex = 2;
            // 
            // textBox_Produto
            // 
            this.textBox_Produto.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Produto.Location = new System.Drawing.Point(211, 64);
            this.textBox_Produto.Multiline = true;
            this.textBox_Produto.Name = "textBox_Produto";
            this.textBox_Produto.Size = new System.Drawing.Size(259, 23);
            this.textBox_Produto.TabIndex = 1;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(185, 25);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(285, 23);
            this.textBox_Nome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroRemedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 599);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastroRemedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroRemedio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_Quantidade;
        private System.Windows.Forms.TextBox textBox_Preco;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.TextBox textBox_Utilidade;
        private System.Windows.Forms.TextBox textBox_Produto;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_remedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
    }
}