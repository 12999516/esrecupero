namespace es
{
    partial class Fmassimo
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
            this.lbl_massimo = new System.Windows.Forms.Label();
            this.txt_massimo = new System.Windows.Forms.TextBox();
            this.btn_massimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_massimo
            // 
            this.lbl_massimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_massimo.Location = new System.Drawing.Point(7, 9);
            this.lbl_massimo.Name = "lbl_massimo";
            this.lbl_massimo.Size = new System.Drawing.Size(165, 35);
            this.lbl_massimo.TabIndex = 0;
            this.lbl_massimo.Text = "inserisci il prezzo massimo";
            // 
            // txt_massimo
            // 
            this.txt_massimo.Location = new System.Drawing.Point(35, 47);
            this.txt_massimo.Name = "txt_massimo";
            this.txt_massimo.Size = new System.Drawing.Size(92, 22);
            this.txt_massimo.TabIndex = 1;
            this.txt_massimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_massimo_KeyPress);
            // 
            // btn_massimo
            // 
            this.btn_massimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_massimo.Location = new System.Drawing.Point(23, 75);
            this.btn_massimo.Name = "btn_massimo";
            this.btn_massimo.Size = new System.Drawing.Size(117, 60);
            this.btn_massimo.TabIndex = 2;
            this.btn_massimo.Text = "conferma";
            this.btn_massimo.UseVisualStyleBackColor = true;
            this.btn_massimo.Click += new System.EventHandler(this.btn_massimo_Click);
            // 
            // Fmassimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 147);
            this.Controls.Add(this.btn_massimo);
            this.Controls.Add(this.txt_massimo);
            this.Controls.Add(this.lbl_massimo);
            this.Name = "Fmassimo";
            this.Text = "Fmassimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_massimo;
        private System.Windows.Forms.TextBox txt_massimo;
        private System.Windows.Forms.Button btn_massimo;
    }
}