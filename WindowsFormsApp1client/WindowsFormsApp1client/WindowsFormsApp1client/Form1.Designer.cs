namespace WindowsFormsApp1client
{
    partial class DNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnOpenWebsite = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.cmbQueryType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(300, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNS LOOKUP CLIENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER DOMAIN NAME/IP: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDomain.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDomain.Location = new System.Drawing.Point(456, 82);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(228, 23);
            this.txtDomain.TabIndex = 2;
            this.txtDomain.Text = "        i.e:- google.com or 8.8.8.8";
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnLookup.ForeColor = System.Drawing.Color.Navy;
            this.btnLookup.Location = new System.Drawing.Point(121, 179);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(2);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(164, 69);
            this.btnLookup.TabIndex = 3;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnOpenWebsite
            // 
            this.btnOpenWebsite.BackColor = System.Drawing.Color.Ivory;
            this.btnOpenWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnOpenWebsite.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOpenWebsite.Location = new System.Drawing.Point(360, 179);
            this.btnOpenWebsite.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenWebsite.Name = "btnOpenWebsite";
            this.btnOpenWebsite.Size = new System.Drawing.Size(233, 69);
            this.btnOpenWebsite.TabIndex = 4;
            this.btnOpenWebsite.Text = "Open Website";
            this.btnOpenWebsite.UseVisualStyleBackColor = false;
            this.btnOpenWebsite.Click += new System.EventHandler(this.btnOpenWebsite_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(644, 179);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 69);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(154, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Results";
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(159, 324);
            this.lstResults.Margin = new System.Windows.Forms.Padding(2);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(612, 64);
            this.lstResults.TabIndex = 7;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // cmbQueryType
            // 
            this.cmbQueryType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbQueryType.FormattingEnabled = true;
            this.cmbQueryType.Location = new System.Drawing.Point(360, 125);
            this.cmbQueryType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbQueryType.Name = "cmbQueryType";
            this.cmbQueryType.Size = new System.Drawing.Size(352, 23);
            this.cmbQueryType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(204, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose any type: ";
            // 
            // DNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbQueryType);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpenWebsite);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DNS";
            this.Text = "DNS Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnOpenWebsite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.ComboBox cmbQueryType;
        private System.Windows.Forms.Label label4;
    }
}

