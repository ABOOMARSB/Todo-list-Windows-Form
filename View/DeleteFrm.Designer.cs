
namespace PraktijkOpdracht.View
{
    partial class DeleteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lvDeleteFrm = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/ef595469916383.5b940" +
    "de05547b.gif";
            this.pictureBox1.Location = new System.Drawing.Point(317, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeleteTitle
            // 
            this.lblDeleteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeleteTitle.AutoEllipsis = true;
            this.lblDeleteTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDeleteTitle.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDeleteTitle.Location = new System.Drawing.Point(12, 126);
            this.lblDeleteTitle.MaximumSize = new System.Drawing.Size(801, 400);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(533, 165);
            this.lblDeleteTitle.TabIndex = 1;
            this.lblDeleteTitle.Text = "Weet je zeker dat je dit item wilt verwijderen?";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
            this.btnYes.Location = new System.Drawing.Point(16, 386);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(197, 64);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Graag";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.btnNo.Location = new System.Drawing.Point(347, 386);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(198, 64);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Helaas nog niet";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lvDeleteFrm
            // 
            this.lvDeleteFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDeleteFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.lvDeleteFrm.HideSelection = false;
            this.lvDeleteFrm.Location = new System.Drawing.Point(16, 294);
            this.lvDeleteFrm.MaximumSize = new System.Drawing.Size(801, 400);
            this.lvDeleteFrm.Name = "lvDeleteFrm";
            this.lvDeleteFrm.Size = new System.Drawing.Size(529, 64);
            this.lvDeleteFrm.TabIndex = 4;
            this.lvDeleteFrm.UseCompatibleStateImageBehavior = false;
            this.lvDeleteFrm.Visible = false;
            // 
            // DeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1223, 650);
            this.Controls.Add(this.lvDeleteFrm);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblDeleteTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteFrm";
            this.Text = "FrmDelete";
            this.Load += new System.EventHandler(this.DeleteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeleteTitle;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ListView lvDeleteFrm;
    }
}