namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtg_main = new System.Windows.Forms.DataGridView();
            this.btn_filtra = new System.Windows.Forms.Button();
            this.btn_disponibili = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_main = new System.Windows.Forms.Label();
            this.lbl_quantità = new System.Windows.Forms.Label();
            this.lbl_prezzo = new System.Windows.Forms.Label();
            this.txt_prezzo = new System.Windows.Forms.TextBox();
            this.txt_quantità = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.btn_agg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_main)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_main
            // 
            this.dtg_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_main.Location = new System.Drawing.Point(0, 0);
            this.dtg_main.Name = "dtg_main";
            this.dtg_main.RowHeadersWidth = 51;
            this.dtg_main.RowTemplate.Height = 24;
            this.dtg_main.Size = new System.Drawing.Size(572, 299);
            this.dtg_main.TabIndex = 0;
            // 
            // btn_filtra
            // 
            this.btn_filtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtra.Location = new System.Drawing.Point(367, 305);
            this.btn_filtra.Name = "btn_filtra";
            this.btn_filtra.Size = new System.Drawing.Size(166, 65);
            this.btn_filtra.TabIndex = 1;
            this.btn_filtra.Text = "filtra";
            this.btn_filtra.UseVisualStyleBackColor = true;
            this.btn_filtra.Click += new System.EventHandler(this.btn_filtra_Click);
            // 
            // btn_disponibili
            // 
            this.btn_disponibili.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disponibili.Location = new System.Drawing.Point(204, 305);
            this.btn_disponibili.Name = "btn_disponibili";
            this.btn_disponibili.Size = new System.Drawing.Size(157, 65);
            this.btn_disponibili.TabIndex = 2;
            this.btn_disponibili.Text = "vedi disponibili";
            this.btn_disponibili.UseVisualStyleBackColor = true;
            this.btn_disponibili.Click += new System.EventHandler(this.btn_disponibili_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(578, 98);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(138, 30);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "nome prodotto";
            // 
            // lbl_main
            // 
            this.lbl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.Location = new System.Drawing.Point(578, 9);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(187, 82);
            this.lbl_main.TabIndex = 4;
            this.lbl_main.Text = "comandi per aggiungere un alimento\r\n\r\n";
            // 
            // lbl_quantità
            // 
            this.lbl_quantità.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantità.Location = new System.Drawing.Point(578, 238);
            this.lbl_quantità.Name = "lbl_quantità";
            this.lbl_quantità.Size = new System.Drawing.Size(100, 23);
            this.lbl_quantità.TabIndex = 5;
            this.lbl_quantità.Text = "quantità";
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezzo.Location = new System.Drawing.Point(578, 167);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(100, 23);
            this.lbl_prezzo.TabIndex = 6;
            this.lbl_prezzo.Text = "prezzo";
            // 
            // txt_prezzo
            // 
            this.txt_prezzo.Location = new System.Drawing.Point(583, 202);
            this.txt_prezzo.Name = "txt_prezzo";
            this.txt_prezzo.Size = new System.Drawing.Size(100, 22);
            this.txt_prezzo.TabIndex = 7;
            this.txt_prezzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prezzo_KeyPress);
            // 
            // txt_quantità
            // 
            this.txt_quantità.Location = new System.Drawing.Point(583, 274);
            this.txt_quantità.Name = "txt_quantità";
            this.txt_quantità.Size = new System.Drawing.Size(100, 22);
            this.txt_quantità.TabIndex = 8;
            this.txt_quantità.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantità_KeyPress);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(583, 131);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 22);
            this.txt_nome.TabIndex = 9;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // btn_conferma
            // 
            this.btn_conferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.Location = new System.Drawing.Point(12, 305);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(186, 65);
            this.btn_conferma.TabIndex = 10;
            this.btn_conferma.Text = "conferma dati alimento";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // btn_agg
            // 
            this.btn_agg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agg.Location = new System.Drawing.Point(539, 305);
            this.btn_agg.Name = "btn_agg";
            this.btn_agg.Size = new System.Drawing.Size(144, 65);
            this.btn_agg.TabIndex = 11;
            this.btn_agg.Text = "aggiungi alimento";
            this.btn_agg.UseVisualStyleBackColor = true;
            this.btn_agg.Click += new System.EventHandler(this.btn_agg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 383);
            this.Controls.Add(this.btn_agg);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_quantità);
            this.Controls.Add(this.txt_prezzo);
            this.Controls.Add(this.lbl_prezzo);
            this.Controls.Add(this.lbl_quantità);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_disponibili);
            this.Controls.Add(this.btn_filtra);
            this.Controls.Add(this.dtg_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_main;
        private System.Windows.Forms.Button btn_filtra;
        private System.Windows.Forms.Button btn_disponibili;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Label lbl_quantità;
        private System.Windows.Forms.Label lbl_prezzo;
        private System.Windows.Forms.TextBox txt_prezzo;
        private System.Windows.Forms.TextBox txt_quantità;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.Button btn_agg;
    }
}

