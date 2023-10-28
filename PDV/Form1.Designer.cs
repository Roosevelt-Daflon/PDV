namespace PDV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btnVenda = new Button();
            btnDetalhe = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Valor, Data, Quantidade });
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 324);
            dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.HeaderText = "Quantiade de produtos";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // btnVenda
            // 
            btnVenda.Location = new Point(12, 388);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(162, 50);
            btnVenda.TabIndex = 1;
            btnVenda.Text = "Realizar Venda";
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += btnVenda_Click;
            // 
            // btnDetalhe
            // 
            btnDetalhe.Location = new Point(626, 388);
            btnDetalhe.Name = "btnDetalhe";
            btnDetalhe.Size = new Size(162, 50);
            btnDetalhe.TabIndex = 2;
            btnDetalhe.Text = "Detalhes da venda";
            btnDetalhe.UseVisualStyleBackColor = true;
            btnDetalhe.Click += btnDetalhe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(352, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 46);
            label1.TabIndex = 6;
            label1.Text = "Vendas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDetalhe);
            Controls.Add(btnVenda);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnVenda;
        private Button btnDetalhe;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Quantidade;
        private Label label1;
    }
}