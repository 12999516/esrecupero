namespace es
{
    partial class Fagg
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
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_si = new System.Windows.Forms.Button();
            this.lbl_vuoi = new System.Windows.Forms.Label();
            this.lbl_qt = new System.Windows.Forms.Label();
            this.txt_qt = new System.Windows.Forms.TextBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(52, 74);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(105, 80);
            this.btn_no.TabIndex = 0;
            this.btn_no.Text = " no";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_si
            // 
            this.btn_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.Location = new System.Drawing.Point(275, 74);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(105, 80);
            this.btn_si.TabIndex = 1;
            this.btn_si.Text = "si";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // lbl_vuoi
            // 
            this.lbl_vuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuoi.Location = new System.Drawing.Point(106, 16);
            this.lbl_vuoi.Name = "lbl_vuoi";
            this.lbl_vuoi.Size = new System.Drawing.Size(274, 35);
            this.lbl_vuoi.TabIndex = 2;
            this.lbl_vuoi.Text = "vuoi aggiungere alimenti";
            // 
            // lbl_qt
            // 
            this.lbl_qt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qt.Location = new System.Drawing.Point(184, 176);
            this.lbl_qt.Name = "lbl_qt";
            this.lbl_qt.Size = new System.Drawing.Size(113, 37);
            this.lbl_qt.TabIndex = 3;
            this.lbl_qt.Text = "quanto";
            // 
            // txt_qt
            // 
            this.txt_qt.Location = new System.Drawing.Point(171, 216);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(100, 22);
            this.txt_qt.TabIndex = 4;
            this.txt_qt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qt_KeyPress);
            // 
            // btn_conferma
            // 
            this.btn_conferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.Location = new System.Drawing.Point(162, 244);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(122, 59);
            this.btn_conferma.TabIndex = 5;
            this.btn_conferma.Text = "conferma";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // Fagg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 315);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.txt_qt);
            this.Controls.Add(this.lbl_qt);
            this.Controls.Add(this.lbl_vuoi);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_no);
            this.Name = "Fagg";
            this.Text = "Fagg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Label lbl_vuoi;
        private System.Windows.Forms.Label lbl_qt;
        private System.Windows.Forms.TextBox txt_qt;
        private System.Windows.Forms.Button btn_conferma;
    }
}