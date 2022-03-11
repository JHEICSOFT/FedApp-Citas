
namespace PlayerUI
{
    partial class DescPadronNominal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.webpadron = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncnv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.webpadron);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 679);
            this.panel2.TabIndex = 1;
            // 
            // webpadron
            // 
            this.webpadron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webpadron.Location = new System.Drawing.Point(0, 65);
            this.webpadron.MinimumSize = new System.Drawing.Size(20, 20);
            this.webpadron.Name = "webpadron";
            this.webpadron.ScriptErrorsSuppressed = true;
            this.webpadron.Size = new System.Drawing.Size(687, 614);
            this.webpadron.TabIndex = 0;
            this.webpadron.Url = new System.Uri("", System.UriKind.Relative);
            this.webpadron.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webpadron_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblexit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 65);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btncnv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(687, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 614);
            this.panel3.TabIndex = 1;
            // 
            // btncnv
            // 
            this.btncnv.Location = new System.Drawing.Point(6, 6);
            this.btncnv.Name = "btncnv";
            this.btncnv.Size = new System.Drawing.Size(105, 33);
            this.btncnv.TabIndex = 0;
            this.btncnv.Text = "Cargar padron";
            this.btncnv.UseVisualStyleBackColor = true;
            this.btncnv.Click += new System.EventHandler(this.btncnv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guia de Importacion cnv-padron nominal a sql";
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblexit.Location = new System.Drawing.Point(6, 7);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(24, 25);
            this.lblexit.TabIndex = 1;
            this.lblexit.Text = "x";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 65);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(687, 614);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/channel/UC4qyW9Ta9jpeBGiJRblKdCw", System.UriKind.Absolute);
            // 
            // DescPadronNominal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(810, 679);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescPadronNominal";
            this.Text = "DescPadronNominal";
            this.Load += new System.EventHandler(this.DescPadronNominal_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webpadron;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncnv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}