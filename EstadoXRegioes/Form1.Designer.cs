namespace EstadoXRegioes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxTodos = new System.Windows.Forms.ComboBox();
            this.cbxNorte = new System.Windows.Forms.ComboBox();
            this.cbxNordeste = new System.Windows.Forms.ComboBox();
            this.cbxSudeste = new System.Windows.Forms.ComboBox();
            this.cbxCentroOeste = new System.Windows.Forms.ComboBox();
            this.cbxSul = new System.Windows.Forms.ComboBox();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblNorte = new System.Windows.Forms.Label();
            this.lblNordeste = new System.Windows.Forms.Label();
            this.lblSudeste = new System.Windows.Forms.Label();
            this.lblCentroOeste = new System.Windows.Forms.Label();
            this.lblSul = new System.Windows.Forms.Label();
            this.removeFromAll = new System.Windows.Forms.Button();
            this.removeFromNorte = new System.Windows.Forms.Button();
            this.removeFromSudeste = new System.Windows.Forms.Button();
            this.removeFromNordeste = new System.Windows.Forms.Button();
            this.removeFromCentroOeste = new System.Windows.Forms.Button();
            this.removeFromSul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAmountNorte = new System.Windows.Forms.Label();
            this.lblAmountNordeste = new System.Windows.Forms.Label();
            this.lblAmountSudeste = new System.Windows.Forms.Label();
            this.lblAmountCentroOeste = new System.Windows.Forms.Label();
            this.lblAmountSul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTodos
            // 
            this.cbxTodos.FormattingEnabled = true;
            this.cbxTodos.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxTodos.Location = new System.Drawing.Point(280, 12);
            this.cbxTodos.Name = "cbxTodos";
            this.cbxTodos.Size = new System.Drawing.Size(231, 21);
            this.cbxTodos.TabIndex = 0;
            // 
            // cbxNorte
            // 
            this.cbxNorte.FormattingEnabled = true;
            this.cbxNorte.Location = new System.Drawing.Point(280, 73);
            this.cbxNorte.Name = "cbxNorte";
            this.cbxNorte.Size = new System.Drawing.Size(231, 21);
            this.cbxNorte.TabIndex = 1;
            // 
            // cbxNordeste
            // 
            this.cbxNordeste.FormattingEnabled = true;
            this.cbxNordeste.Location = new System.Drawing.Point(280, 141);
            this.cbxNordeste.Name = "cbxNordeste";
            this.cbxNordeste.Size = new System.Drawing.Size(231, 21);
            this.cbxNordeste.TabIndex = 2;
            // 
            // cbxSudeste
            // 
            this.cbxSudeste.FormattingEnabled = true;
            this.cbxSudeste.Location = new System.Drawing.Point(280, 215);
            this.cbxSudeste.Name = "cbxSudeste";
            this.cbxSudeste.Size = new System.Drawing.Size(231, 21);
            this.cbxSudeste.TabIndex = 3;
            // 
            // cbxCentroOeste
            // 
            this.cbxCentroOeste.FormattingEnabled = true;
            this.cbxCentroOeste.Location = new System.Drawing.Point(280, 290);
            this.cbxCentroOeste.Name = "cbxCentroOeste";
            this.cbxCentroOeste.Size = new System.Drawing.Size(231, 21);
            this.cbxCentroOeste.TabIndex = 4;
            // 
            // cbxSul
            // 
            this.cbxSul.FormattingEnabled = true;
            this.cbxSul.Location = new System.Drawing.Point(280, 364);
            this.cbxSul.Name = "cbxSul";
            this.cbxSul.Size = new System.Drawing.Size(231, 21);
            this.cbxSul.TabIndex = 5;
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(183, 17);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(91, 13);
            this.lblAll.TabIndex = 6;
            this.lblAll.Text = "Todos os estados";
            // 
            // lblNorte
            // 
            this.lblNorte.AutoSize = true;
            this.lblNorte.Location = new System.Drawing.Point(204, 76);
            this.lblNorte.Name = "lblNorte";
            this.lblNorte.Size = new System.Drawing.Size(70, 13);
            this.lblNorte.TabIndex = 7;
            this.lblNorte.Text = "Região Norte";
            // 
            // lblNordeste
            // 
            this.lblNordeste.AutoSize = true;
            this.lblNordeste.Location = new System.Drawing.Point(187, 149);
            this.lblNordeste.Name = "lblNordeste";
            this.lblNordeste.Size = new System.Drawing.Size(87, 13);
            this.lblNordeste.TabIndex = 8;
            this.lblNordeste.Text = "Região Nordeste";
            // 
            // lblSudeste
            // 
            this.lblSudeste.AutoSize = true;
            this.lblSudeste.Location = new System.Drawing.Point(191, 223);
            this.lblSudeste.Name = "lblSudeste";
            this.lblSudeste.Size = new System.Drawing.Size(83, 13);
            this.lblSudeste.TabIndex = 9;
            this.lblSudeste.Text = "Região Sudeste";
            // 
            // lblCentroOeste
            // 
            this.lblCentroOeste.AutoSize = true;
            this.lblCentroOeste.Location = new System.Drawing.Point(168, 293);
            this.lblCentroOeste.Name = "lblCentroOeste";
            this.lblCentroOeste.Size = new System.Drawing.Size(106, 13);
            this.lblCentroOeste.TabIndex = 10;
            this.lblCentroOeste.Text = "Região Centro-Oeste";
            // 
            // lblSul
            // 
            this.lblSul.AutoSize = true;
            this.lblSul.Location = new System.Drawing.Point(215, 367);
            this.lblSul.Name = "lblSul";
            this.lblSul.Size = new System.Drawing.Size(59, 13);
            this.lblSul.TabIndex = 11;
            this.lblSul.Text = "Região Sul";
            // 
            // removeFromAll
            // 
            this.removeFromAll.Location = new System.Drawing.Point(517, 12);
            this.removeFromAll.Name = "removeFromAll";
            this.removeFromAll.Size = new System.Drawing.Size(75, 23);
            this.removeFromAll.TabIndex = 12;
            this.removeFromAll.Text = "-";
            this.removeFromAll.UseVisualStyleBackColor = true;
            this.removeFromAll.Click += new System.EventHandler(this.removeFromAll_Click);
            // 
            // removeFromNorte
            // 
            this.removeFromNorte.Location = new System.Drawing.Point(517, 73);
            this.removeFromNorte.Name = "removeFromNorte";
            this.removeFromNorte.Size = new System.Drawing.Size(75, 23);
            this.removeFromNorte.TabIndex = 13;
            this.removeFromNorte.Text = "-";
            this.removeFromNorte.UseVisualStyleBackColor = true;
            this.removeFromNorte.Click += new System.EventHandler(this.removeFromNorte_Click);
            // 
            // removeFromSudeste
            // 
            this.removeFromSudeste.Location = new System.Drawing.Point(517, 213);
            this.removeFromSudeste.Name = "removeFromSudeste";
            this.removeFromSudeste.Size = new System.Drawing.Size(75, 23);
            this.removeFromSudeste.TabIndex = 15;
            this.removeFromSudeste.Text = "-";
            this.removeFromSudeste.UseVisualStyleBackColor = true;
            this.removeFromSudeste.Click += new System.EventHandler(this.removeFromSudeste_Click);
            // 
            // removeFromNordeste
            // 
            this.removeFromNordeste.Location = new System.Drawing.Point(517, 144);
            this.removeFromNordeste.Name = "removeFromNordeste";
            this.removeFromNordeste.Size = new System.Drawing.Size(75, 23);
            this.removeFromNordeste.TabIndex = 14;
            this.removeFromNordeste.Text = "-";
            this.removeFromNordeste.UseVisualStyleBackColor = true;
            this.removeFromNordeste.Click += new System.EventHandler(this.removeFromNordeste_Click);
            // 
            // removeFromCentroOeste
            // 
            this.removeFromCentroOeste.Location = new System.Drawing.Point(517, 283);
            this.removeFromCentroOeste.Name = "removeFromCentroOeste";
            this.removeFromCentroOeste.Size = new System.Drawing.Size(75, 23);
            this.removeFromCentroOeste.TabIndex = 16;
            this.removeFromCentroOeste.Text = "-";
            this.removeFromCentroOeste.UseVisualStyleBackColor = true;
            this.removeFromCentroOeste.Click += new System.EventHandler(this.removeFromCentroOeste_Click);
            // 
            // removeFromSul
            // 
            this.removeFromSul.Location = new System.Drawing.Point(517, 362);
            this.removeFromSul.Name = "removeFromSul";
            this.removeFromSul.Size = new System.Drawing.Size(75, 23);
            this.removeFromSul.TabIndex = 17;
            this.removeFromSul.Text = "-";
            this.removeFromSul.UseVisualStyleBackColor = true;
            this.removeFromSul.Click += new System.EventHandler(this.removeFromSul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "27";
            // 
            // lblAmountNorte
            // 
            this.lblAmountNorte.AutoSize = true;
            this.lblAmountNorte.Location = new System.Drawing.Point(632, 73);
            this.lblAmountNorte.Name = "lblAmountNorte";
            this.lblAmountNorte.Size = new System.Drawing.Size(13, 13);
            this.lblAmountNorte.TabIndex = 19;
            this.lblAmountNorte.Text = "0";
            // 
            // lblAmountNordeste
            // 
            this.lblAmountNordeste.AutoSize = true;
            this.lblAmountNordeste.Location = new System.Drawing.Point(632, 144);
            this.lblAmountNordeste.Name = "lblAmountNordeste";
            this.lblAmountNordeste.Size = new System.Drawing.Size(13, 13);
            this.lblAmountNordeste.TabIndex = 20;
            this.lblAmountNordeste.Text = "0";
            // 
            // lblAmountSudeste
            // 
            this.lblAmountSudeste.AutoSize = true;
            this.lblAmountSudeste.Location = new System.Drawing.Point(632, 218);
            this.lblAmountSudeste.Name = "lblAmountSudeste";
            this.lblAmountSudeste.Size = new System.Drawing.Size(13, 13);
            this.lblAmountSudeste.TabIndex = 21;
            this.lblAmountSudeste.Text = "0";
            // 
            // lblAmountCentroOeste
            // 
            this.lblAmountCentroOeste.AutoSize = true;
            this.lblAmountCentroOeste.Location = new System.Drawing.Point(632, 290);
            this.lblAmountCentroOeste.Name = "lblAmountCentroOeste";
            this.lblAmountCentroOeste.Size = new System.Drawing.Size(13, 13);
            this.lblAmountCentroOeste.TabIndex = 23;
            this.lblAmountCentroOeste.Text = "0";
            // 
            // lblAmountSul
            // 
            this.lblAmountSul.AutoSize = true;
            this.lblAmountSul.Location = new System.Drawing.Point(632, 364);
            this.lblAmountSul.Name = "lblAmountSul";
            this.lblAmountSul.Size = new System.Drawing.Size(13, 13);
            this.lblAmountSul.TabIndex = 24;
            this.lblAmountSul.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAmountSul);
            this.Controls.Add(this.lblAmountCentroOeste);
            this.Controls.Add(this.lblAmountSudeste);
            this.Controls.Add(this.lblAmountNordeste);
            this.Controls.Add(this.lblAmountNorte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.removeFromSul);
            this.Controls.Add(this.removeFromCentroOeste);
            this.Controls.Add(this.removeFromSudeste);
            this.Controls.Add(this.removeFromNordeste);
            this.Controls.Add(this.removeFromNorte);
            this.Controls.Add(this.removeFromAll);
            this.Controls.Add(this.lblSul);
            this.Controls.Add(this.lblCentroOeste);
            this.Controls.Add(this.lblSudeste);
            this.Controls.Add(this.lblNordeste);
            this.Controls.Add(this.lblNorte);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.cbxSul);
            this.Controls.Add(this.cbxCentroOeste);
            this.Controls.Add(this.cbxSudeste);
            this.Controls.Add(this.cbxNordeste);
            this.Controls.Add(this.cbxNorte);
            this.Controls.Add(this.cbxTodos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTodos;
        private System.Windows.Forms.ComboBox cbxNorte;
        private System.Windows.Forms.ComboBox cbxNordeste;
        private System.Windows.Forms.ComboBox cbxSudeste;
        private System.Windows.Forms.ComboBox cbxCentroOeste;
        private System.Windows.Forms.ComboBox cbxSul;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblNorte;
        private System.Windows.Forms.Label lblNordeste;
        private System.Windows.Forms.Label lblSudeste;
        private System.Windows.Forms.Label lblCentroOeste;
        private System.Windows.Forms.Label lblSul;
        private System.Windows.Forms.Button removeFromAll;
        private System.Windows.Forms.Button removeFromNorte;
        private System.Windows.Forms.Button removeFromSudeste;
        private System.Windows.Forms.Button removeFromNordeste;
        private System.Windows.Forms.Button removeFromCentroOeste;
        private System.Windows.Forms.Button removeFromSul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAmountNorte;
        private System.Windows.Forms.Label lblAmountNordeste;
        private System.Windows.Forms.Label lblAmountSudeste;
        private System.Windows.Forms.Label lblAmountCentroOeste;
        private System.Windows.Forms.Label lblAmountSul;
    }
}

