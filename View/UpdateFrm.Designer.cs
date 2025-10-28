
namespace PraktijkOpdracht.View
{
    partial class UpdateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFrm));
            this.lvUpdate = new System.Windows.Forms.ListView();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtInleverdatum = new System.Windows.Forms.DateTimePicker();
            this.dtStartdatum = new System.Windows.Forms.DateTimePicker();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbOmschrijving = new System.Windows.Forms.TextBox();
            this.tbTaak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThema = new System.Windows.Forms.ComboBox();
            this.cbModule = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvUpdate
            // 
            this.lvUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.lvUpdate.HideSelection = false;
            this.lvUpdate.Location = new System.Drawing.Point(25, 217);
            this.lvUpdate.MaximumSize = new System.Drawing.Size(801, 400);
            this.lvUpdate.Name = "lvUpdate";
            this.lvUpdate.Size = new System.Drawing.Size(528, 72);
            this.lvUpdate.TabIndex = 9;
            this.lvUpdate.UseCompatibleStateImageBehavior = false;
            this.lvUpdate.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.btnNo.Location = new System.Drawing.Point(355, 564);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(198, 64);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "Helaas nog niet";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYes.Location = new System.Drawing.Point(25, 564);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(197, 64);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "Graag";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdateTitle.AutoEllipsis = true;
            this.lblUpdateTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUpdateTitle.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUpdateTitle.Location = new System.Drawing.Point(25, 28);
            this.lblUpdateTitle.MaximumSize = new System.Drawing.Size(801, 400);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(528, 165);
            this.lblUpdateTitle.TabIndex = 6;
            this.lblUpdateTitle.Text = "Weet je zeker dat je dit item aan wilt passen?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/44ba7969916383.5b940" +
    "de05310a.gif";
            this.pictureBox1.Location = new System.Drawing.Point(355, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dtInleverdatum
            // 
            this.dtInleverdatum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtInleverdatum.Location = new System.Drawing.Point(180, 465);
            this.dtInleverdatum.Name = "dtInleverdatum";
            this.dtInleverdatum.Size = new System.Drawing.Size(364, 27);
            this.dtInleverdatum.TabIndex = 34;
            // 
            // dtStartdatum
            // 
            this.dtStartdatum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtStartdatum.Location = new System.Drawing.Point(180, 432);
            this.dtStartdatum.Name = "dtStartdatum";
            this.dtStartdatum.Size = new System.Drawing.Size(364, 27);
            this.dtStartdatum.TabIndex = 33;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.tbStatus.Location = new System.Drawing.Point(180, 499);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(364, 23);
            this.tbStatus.TabIndex = 32;
            // 
            // tbOmschrijving
            // 
            this.tbOmschrijving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.tbOmschrijving.Location = new System.Drawing.Point(180, 403);
            this.tbOmschrijving.Multiline = true;
            this.tbOmschrijving.Name = "tbOmschrijving";
            this.tbOmschrijving.Size = new System.Drawing.Size(364, 23);
            this.tbOmschrijving.TabIndex = 31;
            // 
            // tbTaak
            // 
            this.tbTaak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.tbTaak.Location = new System.Drawing.Point(180, 372);
            this.tbTaak.Multiline = true;
            this.tbTaak.Name = "tbTaak";
            this.tbTaak.Size = new System.Drawing.Size(364, 23);
            this.tbTaak.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Inleverdatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Startdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Omschrijving:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Taak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Thema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Module:";
            // 
            // cbThema
            // 
            this.cbThema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.cbThema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbThema.ForeColor = System.Drawing.Color.Maroon;
            this.cbThema.FormattingEnabled = true;
            this.cbThema.Items.AddRange(new object[] {
            "Thema 7",
            "Thema 8"});
            this.cbThema.Location = new System.Drawing.Point(180, 338);
            this.cbThema.Name = "cbThema";
            this.cbThema.Size = new System.Drawing.Size(364, 28);
            this.cbThema.TabIndex = 35;
            this.cbThema.Text = "Selecteer een thema...";
            // 
            // cbModule
            // 
            this.cbModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.cbModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbModule.ForeColor = System.Drawing.Color.Maroon;
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Items.AddRange(new object[] {
            "Realiseren",
            "Praktijk",
            "Plannen en ontwerpen",
            "Testen en verbeteren",
            "Computervaardigheden"});
            this.cbModule.Location = new System.Drawing.Point(180, 301);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(364, 28);
            this.cbModule.TabIndex = 36;
            this.cbModule.Text = "Selecteer een module...";
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1226, 654);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.cbThema);
            this.Controls.Add(this.dtInleverdatum);
            this.Controls.Add(this.dtStartdatum);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbOmschrijving);
            this.Controls.Add(this.tbTaak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvUpdate);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblUpdateTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateFrm";
            this.Text = "UpdateFrm";
            this.Load += new System.EventHandler(this.UpdateFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUpdate;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtInleverdatum;
        private System.Windows.Forms.DateTimePicker dtStartdatum;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbOmschrijving;
        private System.Windows.Forms.TextBox tbTaak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThema;
        private System.Windows.Forms.ComboBox cbModule;
    }
}