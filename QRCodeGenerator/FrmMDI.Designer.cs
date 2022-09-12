namespace QRCodeGenerator
{
    partial class FrmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnWifiType = new System.Windows.Forms.Button();
            this.btnEmailType = new System.Windows.Forms.Button();
            this.btnEventType = new System.Windows.Forms.Button();
            this.btnGPSType = new System.Windows.Forms.Button();
            this.btnCallType = new System.Windows.Forms.Button();
            this.btnSmsType = new System.Windows.Forms.Button();
            this.btnVCardType = new System.Windows.Forms.Button();
            this.btnTextType = new System.Windows.Forms.Button();
            this.btnUrlType = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Controls.Add(this.tableLayoutPanel1);
            this.pnlMenu.Location = new System.Drawing.Point(2, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 646);
            this.pnlMenu.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnWifiType, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnEmailType, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEventType, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGPSType, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCallType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSmsType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVCardType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTextType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUrlType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 646);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnWifiType
            // 
            this.btnWifiType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWifiType.Image = global::QRCodeGenerator.Properties.Resources.wifi;
            this.btnWifiType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWifiType.Location = new System.Drawing.Point(3, 571);
            this.btnWifiType.Name = "btnWifiType";
            this.btnWifiType.Size = new System.Drawing.Size(194, 72);
            this.btnWifiType.TabIndex = 8;
            this.btnWifiType.Text = "Wifi";
            this.btnWifiType.UseVisualStyleBackColor = true;
            // 
            // btnEmailType
            // 
            this.btnEmailType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmailType.Image = global::QRCodeGenerator.Properties.Resources.email;
            this.btnEmailType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmailType.Location = new System.Drawing.Point(3, 500);
            this.btnEmailType.Name = "btnEmailType";
            this.btnEmailType.Size = new System.Drawing.Size(194, 65);
            this.btnEmailType.TabIndex = 7;
            this.btnEmailType.Text = "Email";
            this.btnEmailType.UseVisualStyleBackColor = true;
            // 
            // btnEventType
            // 
            this.btnEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventType.Image = global::QRCodeGenerator.Properties.Resources._event;
            this.btnEventType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventType.Location = new System.Drawing.Point(3, 429);
            this.btnEventType.Name = "btnEventType";
            this.btnEventType.Size = new System.Drawing.Size(194, 65);
            this.btnEventType.TabIndex = 6;
            this.btnEventType.Text = "Evento";
            this.btnEventType.UseVisualStyleBackColor = true;
            // 
            // btnGPSType
            // 
            this.btnGPSType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGPSType.Image = global::QRCodeGenerator.Properties.Resources.geolocalization;
            this.btnGPSType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGPSType.Location = new System.Drawing.Point(3, 358);
            this.btnGPSType.Name = "btnGPSType";
            this.btnGPSType.Size = new System.Drawing.Size(194, 65);
            this.btnGPSType.TabIndex = 5;
            this.btnGPSType.Text = "Localização";
            this.btnGPSType.UseVisualStyleBackColor = true;
            // 
            // btnCallType
            // 
            this.btnCallType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCallType.Image = global::QRCodeGenerator.Properties.Resources.call;
            this.btnCallType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallType.Location = new System.Drawing.Point(3, 287);
            this.btnCallType.Name = "btnCallType";
            this.btnCallType.Size = new System.Drawing.Size(194, 65);
            this.btnCallType.TabIndex = 4;
            this.btnCallType.Text = "Chamada";
            this.btnCallType.UseVisualStyleBackColor = true;
            // 
            // btnSmsType
            // 
            this.btnSmsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmsType.Image = global::QRCodeGenerator.Properties.Resources.sms;
            this.btnSmsType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmsType.Location = new System.Drawing.Point(3, 216);
            this.btnSmsType.Name = "btnSmsType";
            this.btnSmsType.Size = new System.Drawing.Size(194, 65);
            this.btnSmsType.TabIndex = 3;
            this.btnSmsType.Text = "SMS";
            this.btnSmsType.UseVisualStyleBackColor = true;
            // 
            // btnVCardType
            // 
            this.btnVCardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVCardType.Image = global::QRCodeGenerator.Properties.Resources.vcard;
            this.btnVCardType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVCardType.Location = new System.Drawing.Point(3, 145);
            this.btnVCardType.Name = "btnVCardType";
            this.btnVCardType.Size = new System.Drawing.Size(194, 65);
            this.btnVCardType.TabIndex = 2;
            this.btnVCardType.Text = "Contato";
            this.btnVCardType.UseVisualStyleBackColor = true;
            // 
            // btnTextType
            // 
            this.btnTextType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTextType.Image = global::QRCodeGenerator.Properties.Resources.text;
            this.btnTextType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextType.Location = new System.Drawing.Point(3, 74);
            this.btnTextType.Name = "btnTextType";
            this.btnTextType.Size = new System.Drawing.Size(194, 65);
            this.btnTextType.TabIndex = 1;
            this.btnTextType.Text = "Texto";
            this.btnTextType.UseVisualStyleBackColor = true;
            // 
            // btnUrlType
            // 
            this.btnUrlType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUrlType.Image = global::QRCodeGenerator.Properties.Resources.url;
            this.btnUrlType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrlType.Location = new System.Drawing.Point(3, 3);
            this.btnUrlType.Name = "btnUrlType";
            this.btnUrlType.Size = new System.Drawing.Size(194, 65);
            this.btnUrlType.TabIndex = 0;
            this.btnUrlType.Text = "URL";
            this.btnUrlType.UseVisualStyleBackColor = true;
            this.btnUrlType.Click += new System.EventHandler(this.btnUrlType_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 654);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnWifiType;
        private System.Windows.Forms.Button btnEmailType;
        private System.Windows.Forms.Button btnEventType;
        private System.Windows.Forms.Button btnGPSType;
        private System.Windows.Forms.Button btnCallType;
        private System.Windows.Forms.Button btnSmsType;
        private System.Windows.Forms.Button btnVCardType;
        private System.Windows.Forms.Button btnTextType;
        private System.Windows.Forms.Button btnUrlType;
    }
}

