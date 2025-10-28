
namespace PraktijkOpdracht.View
{
    partial class ToDoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvToDo = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbModuleFilter = new System.Windows.Forms.ComboBox();
            this.cbThemaFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResteFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/7c177769916383.5b940" +
    "de0535f9.gif";
            this.pictureBox1.Location = new System.Drawing.Point(360, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1336, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lvToDo
            // 
            this.lvToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvToDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.lvToDo.HideSelection = false;
            this.lvToDo.Location = new System.Drawing.Point(50, 203);
            this.lvToDo.MaximumSize = new System.Drawing.Size(801, 400);
            this.lvToDo.Name = "lvToDo";
            this.lvToDo.Size = new System.Drawing.Size(651, 273);
            this.lvToDo.TabIndex = 1;
            this.lvToDo.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(437, 3);
            this.btnDelete.MaximumSize = new System.Drawing.Size(267, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(220, 3);
            this.btnExport.MaximumSize = new System.Drawing.Size(267, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(211, 48);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.MaximumSize = new System.Drawing.Size(267, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(182, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mijn ToDo\'s";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Location = new System.Drawing.Point(50, 565);
            this.btnCreate.MaximumSize = new System.Drawing.Size(801, 57);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(651, 57);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "New";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 493);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(801, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 54);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // cbModuleFilter
            // 
            this.cbModuleFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.cbModuleFilter.FormattingEnabled = true;
            this.cbModuleFilter.Items.AddRange(new object[] {
            "Realiseren",
            "Praktijk",
            "Plannen en ontwerpen",
            "Testen en verbeteren",
            "Computervaardigheden"});
            this.cbModuleFilter.Location = new System.Drawing.Point(50, 120);
            this.cbModuleFilter.Name = "cbModuleFilter";
            this.cbModuleFilter.Size = new System.Drawing.Size(322, 28);
            this.cbModuleFilter.TabIndex = 8;
            this.cbModuleFilter.Text = "Filteren op module";
            // 
            // cbThemaFilter
            // 
            this.cbThemaFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.cbThemaFilter.FormattingEnabled = true;
            this.cbThemaFilter.Items.AddRange(new object[] {
            "Thema 7",
            "Thema 8"});
            this.cbThemaFilter.Location = new System.Drawing.Point(378, 120);
            this.cbThemaFilter.Name = "cbThemaFilter";
            this.cbThemaFilter.Size = new System.Drawing.Size(323, 28);
            this.cbThemaFilter.TabIndex = 9;
            this.cbThemaFilter.Text = "Filteren op Thema";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(50, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pas mij filters aan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResteFilters
            // 
            this.btnResteFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnResteFilters.Location = new System.Drawing.Point(378, 154);
            this.btnResteFilters.Name = "btnResteFilters";
            this.btnResteFilters.Size = new System.Drawing.Size(322, 43);
            this.btnResteFilters.TabIndex = 11;
            this.btnResteFilters.Text = "Reset my filters";
            this.btnResteFilters.UseVisualStyleBackColor = false;
            this.btnResteFilters.Click += new System.EventHandler(this.btnResteFilters_Click);
            // 
            // ToDoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1331, 643);
            this.Controls.Add(this.btnResteFilters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbThemaFilter);
            this.Controls.Add(this.cbModuleFilter);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvToDo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoView";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDoView_FormClosed);
            this.Load += new System.EventHandler(this.ToDoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvToDo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbModuleFilter;
        private System.Windows.Forms.ComboBox cbThemaFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResteFilters;
    }
}