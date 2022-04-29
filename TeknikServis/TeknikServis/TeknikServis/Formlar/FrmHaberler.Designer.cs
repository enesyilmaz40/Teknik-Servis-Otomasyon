namespace TeknikServis.Formlar
{
    partial class FrmHaberler
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
            this.lstBaslik = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRssUrl = new DevExpress.XtraEditors.TextEdit();
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRssUrl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBaslik
            // 
            this.lstBaslik.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBaslik.FormattingEnabled = true;
            this.lstBaslik.Location = new System.Drawing.Point(0, 0);
            this.lstBaslik.Name = "lstBaslik";
            this.lstBaslik.Size = new System.Drawing.Size(445, 861);
            this.lstBaslik.TabIndex = 0;
            this.lstBaslik.SelectedIndexChanged += new System.EventHandler(this.lstBaslik_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(445, 97);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1469, 764);
            this.webBrowser1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRssUrl);
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(445, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1457, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS ";
            // 
            // txtRssUrl
            // 
            this.txtRssUrl.EditValue = "https://www.sabah.com.tr/rss/ekonomi.xml";
            this.txtRssUrl.Location = new System.Drawing.Point(6, 19);
            this.txtRssUrl.Name = "txtRssUrl";
            this.txtRssUrl.Size = new System.Drawing.Size(488, 20);
            this.txtRssUrl.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(6, 62);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // FrmHaberler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 861);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lstBaslik);
            this.Name = "FrmHaberler";
            this.Text = "Haberler";
            this.Load += new System.EventHandler(this.FrmHaberler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRssUrl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBaslik;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
        private DevExpress.XtraEditors.TextEdit txtRssUrl;
    }
}