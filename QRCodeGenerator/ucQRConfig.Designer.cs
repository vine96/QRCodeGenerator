namespace QRCodeGenerator
{
    partial class ucQRConfig
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbCharsetSource = new System.Windows.Forms.Label();
            this.cmbCharsetTarget = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbECC = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.cmbFormat = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.cmbQZone = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.cmbMargin = new System.Windows.Forms.Label();
            this.cmbBGColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(22, 115);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // cmbCharsetSource
            // 
            this.cmbCharsetSource.AutoSize = true;
            this.cmbCharsetSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCharsetSource.Location = new System.Drawing.Point(18, 153);
            this.cmbCharsetSource.Name = "cmbCharsetSource";
            this.cmbCharsetSource.Size = new System.Drawing.Size(139, 20);
            this.cmbCharsetSource.TabIndex = 4;
            this.cmbCharsetSource.Text = "Charset Source:";
            // 
            // cmbCharsetTarget
            // 
            this.cmbCharsetTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharsetTarget.FormattingEnabled = true;
            this.cmbCharsetTarget.Location = new System.Drawing.Point(22, 234);
            this.cmbCharsetTarget.Name = "cmbCharsetTarget";
            this.cmbCharsetTarget.Size = new System.Drawing.Size(200, 21);
            this.cmbCharsetTarget.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Charset Target:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(22, 298);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // cmbECC
            // 
            this.cmbECC.AutoSize = true;
            this.cmbECC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbECC.Location = new System.Drawing.Point(18, 275);
            this.cmbECC.Name = "cmbECC";
            this.cmbECC.Size = new System.Drawing.Size(50, 20);
            this.cmbECC.TabIndex = 8;
            this.cmbECC.Text = "ECC:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(22, 360);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 21);
            this.comboBox4.TabIndex = 11;
            // 
            // cmbColor
            // 
            this.cmbColor.AutoSize = true;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.Location = new System.Drawing.Point(18, 337);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(56, 20);
            this.cmbColor.TabIndex = 10;
            this.cmbColor.Text = "Color:";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(278, 298);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 21);
            this.comboBox5.TabIndex = 19;
            // 
            // cmbFormat
            // 
            this.cmbFormat.AutoSize = true;
            this.cmbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormat.Location = new System.Drawing.Point(274, 275);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(71, 20);
            this.cmbFormat.TabIndex = 18;
            this.cmbFormat.Text = "Format:";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(278, 234);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 21);
            this.comboBox6.TabIndex = 17;
            // 
            // cmbQZone
            // 
            this.cmbQZone.AutoSize = true;
            this.cmbQZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQZone.Location = new System.Drawing.Point(274, 211);
            this.cmbQZone.Name = "cmbQZone";
            this.cmbQZone.Size = new System.Drawing.Size(68, 20);
            this.cmbQZone.TabIndex = 16;
            this.cmbQZone.Text = "QZone:";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(278, 176);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(200, 21);
            this.comboBox7.TabIndex = 15;
            // 
            // cmbMargin
            // 
            this.cmbMargin.AutoSize = true;
            this.cmbMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMargin.Location = new System.Drawing.Point(274, 153);
            this.cmbMargin.Name = "cmbMargin";
            this.cmbMargin.Size = new System.Drawing.Size(68, 20);
            this.cmbMargin.TabIndex = 14;
            this.cmbMargin.Text = "Margin:";
            // 
            // cmbBGColor
            // 
            this.cmbBGColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBGColor.FormattingEnabled = true;
            this.cmbBGColor.Location = new System.Drawing.Point(278, 115);
            this.cmbBGColor.Name = "cmbBGColor";
            this.cmbBGColor.Size = new System.Drawing.Size(200, 21);
            this.cmbBGColor.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "BG Color:";
            // 
            // ucQRConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.cmbQZone);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.cmbMargin);
            this.Controls.Add(this.cmbBGColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbECC);
            this.Controls.Add(this.cmbCharsetTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbCharsetSource);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucQRConfig";
            this.Size = new System.Drawing.Size(500, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cmbCharsetSource;
        private System.Windows.Forms.ComboBox cmbCharsetTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label cmbECC;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label cmbColor;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label cmbFormat;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label cmbQZone;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label cmbMargin;
        private System.Windows.Forms.ComboBox cmbBGColor;
        private System.Windows.Forms.Label label10;
    }
}
