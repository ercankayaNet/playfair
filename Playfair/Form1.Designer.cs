namespace Şifreleme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSifrele = new System.Windows.Forms.Button();
            this.tbAnahtarMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesifrele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSonucMetin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.Color.Bisque;
            this.btnSifrele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifrele.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSifrele.Image = ((System.Drawing.Image)(resources.GetObject("btnSifrele.Image")));
            this.btnSifrele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSifrele.Location = new System.Drawing.Point(130, 399);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(131, 71);
            this.btnSifrele.TabIndex = 3;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // tbAnahtarMetin
            // 
            this.tbAnahtarMetin.BackColor = System.Drawing.Color.SeaShell;
            this.tbAnahtarMetin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAnahtarMetin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbAnahtarMetin.Location = new System.Drawing.Point(130, 48);
            this.tbAnahtarMetin.Multiline = true;
            this.tbAnahtarMetin.Name = "tbAnahtarMetin";
            this.tbAnahtarMetin.Size = new System.Drawing.Size(644, 43);
            this.tbAnahtarMetin.TabIndex = 1;
            this.tbAnahtarMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnahtarMetin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(126, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "a b c ç d e f g ğ h i ı j k l m n o ö p r s ş t u ü v y z , . ? ! x w q";
            // 
            // tbMetin
            // 
            this.tbMetin.BackColor = System.Drawing.Color.SeaShell;
            this.tbMetin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMetin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbMetin.Location = new System.Drawing.Point(130, 97);
            this.tbMetin.Multiline = true;
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(644, 145);
            this.tbMetin.TabIndex = 2;
            this.tbMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMetin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metin";
            // 
            // btnDesifrele
            // 
            this.btnDesifrele.BackColor = System.Drawing.Color.Bisque;
            this.btnDesifrele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesifrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesifrele.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDesifrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDesifrele.Image = ((System.Drawing.Image)(resources.GetObject("btnDesifrele.Image")));
            this.btnDesifrele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesifrele.Location = new System.Drawing.Point(267, 399);
            this.btnDesifrele.Name = "btnDesifrele";
            this.btnDesifrele.Size = new System.Drawing.Size(148, 71);
            this.btnDesifrele.TabIndex = 4;
            this.btnDesifrele.Text = "Deşifrele";
            this.btnDesifrele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesifrele.UseVisualStyleBackColor = false;
            this.btnDesifrele.Click += new System.EventHandler(this.btnDesifrele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alfabe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Anahtar Metin";
            // 
            // tbSonucMetin
            // 
            this.tbSonucMetin.BackColor = System.Drawing.Color.SeaShell;
            this.tbSonucMetin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSonucMetin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbSonucMetin.Location = new System.Drawing.Point(130, 248);
            this.tbSonucMetin.Multiline = true;
            this.tbSonucMetin.Name = "tbSonucMetin";
            this.tbSonucMetin.Size = new System.Drawing.Size(644, 145);
            this.tbSonucMetin.TabIndex = 1;
            this.tbSonucMetin.TabStop = false;
            this.tbSonucMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSonucMetin_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sonuç Metin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(796, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSonucMetin);
            this.Controls.Add(this.tbMetin);
            this.Controls.Add(this.tbAnahtarMetin);
            this.Controls.Add(this.btnDesifrele);
            this.Controls.Add(this.btnSifrele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.TextBox tbAnahtarMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesifrele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSonucMetin;
        private System.Windows.Forms.Label label5;
    }
}

