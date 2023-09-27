namespace ListinhaDeCompras
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
            NomeProduto = new TextBox();
            QuantProduto = new TextBox();
            PrecoProduto = new TextBox();
            BotaoADD = new Button();
            Titulo = new Label();
            TextNome = new Label();
            TextQuant = new Label();
            TextPreco = new Label();
            ListaProdutos = new ListBox();
            SuspendLayout();
            // 
            // NomeProduto
            // 
            NomeProduto.BackColor = SystemColors.ButtonHighlight;
            NomeProduto.BorderStyle = BorderStyle.FixedSingle;
            NomeProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeProduto.Location = new Point(31, 109);
            NomeProduto.Name = "NomeProduto";
            NomeProduto.Size = new Size(321, 29);
            NomeProduto.TabIndex = 0;
            NomeProduto.TextChanged += NomeProduto_TextChanged;
            // 
            // QuantProduto
            // 
            QuantProduto.BackColor = SystemColors.ButtonHighlight;
            QuantProduto.BorderStyle = BorderStyle.FixedSingle;
            QuantProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantProduto.Location = new Point(31, 202);
            QuantProduto.Name = "QuantProduto";
            QuantProduto.Size = new Size(129, 29);
            QuantProduto.TabIndex = 1;
            QuantProduto.TextChanged += QuantProduto_TextChanged;
            // 
            // PrecoProduto
            // 
            PrecoProduto.BackColor = SystemColors.ButtonHighlight;
            PrecoProduto.BorderStyle = BorderStyle.FixedSingle;
            PrecoProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoProduto.Location = new Point(214, 202);
            PrecoProduto.Name = "PrecoProduto";
            PrecoProduto.Size = new Size(138, 29);
            PrecoProduto.TabIndex = 2;
            PrecoProduto.TextChanged += PrecoProduto_TextChanged;
            // 
            // BotaoADD
            // 
            BotaoADD.BackColor = SystemColors.Desktop;
            BotaoADD.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BotaoADD.ForeColor = SystemColors.ButtonHighlight;
            BotaoADD.Location = new Point(143, 262);
            BotaoADD.Name = "BotaoADD";
            BotaoADD.Size = new Size(101, 50);
            BotaoADD.TabIndex = 3;
            BotaoADD.Text = "ADD";
            BotaoADD.UseVisualStyleBackColor = false;
            BotaoADD.Click += BotaoADD_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Courier New", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Titulo.Location = new Point(31, 36);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(270, 31);
            Titulo.TabIndex = 5;
            Titulo.Text = "LISTA DE COMPRAS";
            // 
            // TextNome
            // 
            TextNome.AutoSize = true;
            TextNome.Font = new Font("Corbel", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextNome.Location = new Point(31, 83);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(154, 23);
            TextNome.TabIndex = 6;
            TextNome.Text = "Nome do produto:";
            // 
            // TextQuant
            // 
            TextQuant.AutoSize = true;
            TextQuant.Font = new Font("Corbel", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextQuant.Location = new Point(31, 176);
            TextQuant.Name = "TextQuant";
            TextQuant.Size = new Size(70, 23);
            TextQuant.TabIndex = 7;
            TextQuant.Text = "Quant.:";
            // 
            // TextPreco
            // 
            TextPreco.AutoSize = true;
            TextPreco.Font = new Font("Corbel", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextPreco.Location = new Point(214, 176);
            TextPreco.Name = "TextPreco";
            TextPreco.Size = new Size(59, 23);
            TextPreco.TabIndex = 8;
            TextPreco.Text = "Preço:";
            // 
            // ListaProdutos
            // 
            ListaProdutos.BorderStyle = BorderStyle.FixedSingle;
            ListaProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.ItemHeight = 21;
            ListaProdutos.Location = new Point(397, 61);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(362, 233);
            ListaProdutos.TabIndex = 9;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 342);
            Controls.Add(ListaProdutos);
            Controls.Add(TextPreco);
            Controls.Add(TextQuant);
            Controls.Add(TextNome);
            Controls.Add(Titulo);
            Controls.Add(BotaoADD);
            Controls.Add(PrecoProduto);
            Controls.Add(QuantProduto);
            Controls.Add(NomeProduto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NomeProduto;
        private TextBox QuantProduto;
        private TextBox PrecoProduto;
        private Button BotaoADD;
        private Label Titulo;
        private Label TextNome;
        private Label TextQuant;
        private Label TextPreco;
        private ListBox ListaProdutos;
    }
}