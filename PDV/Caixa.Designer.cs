namespace PDV
{
    partial class Caixa
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
            gridProdutos = new DataGridView();
            gridProdutosVenda = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnVenda = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Unidade = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProdutosVenda).BeginInit();
            SuspendLayout();
            // 
            // gridProdutos
            // 
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Preco, Unidade, Estoque, Data });
            gridProdutos.Location = new Point(12, 56);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.RowTemplate.Height = 25;
            gridProdutos.Size = new Size(380, 333);
            gridProdutos.TabIndex = 0;
            // 
            // gridProdutosVenda
            // 
            gridProdutosVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutosVenda.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            gridProdutosVenda.Location = new Point(408, 56);
            gridProdutosVenda.Name = "gridProdutosVenda";
            gridProdutosVenda.RowTemplate.Height = 25;
            gridProdutosVenda.Size = new Size(380, 333);
            gridProdutosVenda.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Preço";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Unidade";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnVenda
            // 
            btnVenda.Location = new Point(626, 395);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(162, 50);
            btnVenda.TabIndex = 2;
            btnVenda.Text = "Realizar Venda";
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += btnVenda_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 395);
            button1.Name = "button1";
            button1.Size = new Size(162, 50);
            button1.TabIndex = 3;
            button1.Text = "Cancelar Venda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 395);
            button2.Name = "button2";
            button2.Size = new Size(162, 50);
            button2.TabIndex = 4;
            button2.Text = "Passar Produto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 7);
            label1.Name = "label1";
            label1.Size = new Size(156, 46);
            label1.TabIndex = 5;
            label1.Text = "Produtos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(442, 9);
            label2.Name = "label2";
            label2.Size = new Size(304, 46);
            label2.TabIndex = 6;
            label2.Text = "Produtos da Venda";
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            // 
            // Unidade
            // 
            Unidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unidade.HeaderText = "Unidade";
            Unidade.Name = "Unidade";
            Unidade.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estoque.HeaderText = "Estoque";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data.HeaderText = "ultima venda";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnVenda);
            Controls.Add(gridProdutosVenda);
            Controls.Add(gridProdutos);
            Name = "Caixa";
            Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProdutosVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProdutos;
        private DataGridView gridProdutosVenda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnVenda;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Unidade;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn Data;
    }
}