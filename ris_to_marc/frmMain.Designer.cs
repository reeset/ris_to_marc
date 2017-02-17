namespace ris_to_marc
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ris = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_save = new System.Windows.Forms.TextBox();
            this.cmdProcess = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartographicResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electronicResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkAssoc = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkTemplates = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 8);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "RIS File:";
            // 
            // txt_ris
            // 
            this.txt_ris.Location = new System.Drawing.Point(114, 141);
            this.txt_ris.MaxLength = 3;
            this.txt_ris.Name = "txt_ris";
            this.txt_ris.Size = new System.Drawing.Size(246, 26);
            this.txt_ris.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Save File:";
            // 
            // txt_save
            // 
            this.txt_save.Location = new System.Drawing.Point(114, 178);
            this.txt_save.MaxLength = 3;
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(246, 26);
            this.txt_save.TabIndex = 7;
            // 
            // cmdProcess
            // 
            this.cmdProcess.Location = new System.Drawing.Point(276, 261);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(100, 30);
            this.cmdProcess.TabIndex = 8;
            this.cmdProcess.Text = "Process File";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(382, 261);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 30);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(375, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.serialToolStripMenuItem,
            this.visualMaterialsToolStripMenuItem,
            this.cartographicResourceToolStripMenuItem,
            this.soundRecordingToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.electronicResourceToolStripMenuItem,
            this.mixMaterialToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 196);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // visualMaterialsToolStripMenuItem
            // 
            this.visualMaterialsToolStripMenuItem.Name = "visualMaterialsToolStripMenuItem";
            this.visualMaterialsToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.visualMaterialsToolStripMenuItem.Text = "Visual Materials";
            this.visualMaterialsToolStripMenuItem.Click += new System.EventHandler(this.visualMaterialsToolStripMenuItem_Click);
            // 
            // cartographicResourceToolStripMenuItem
            // 
            this.cartographicResourceToolStripMenuItem.Name = "cartographicResourceToolStripMenuItem";
            this.cartographicResourceToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.cartographicResourceToolStripMenuItem.Text = "Cartographic Resource";
            this.cartographicResourceToolStripMenuItem.Click += new System.EventHandler(this.cartographicResourceToolStripMenuItem_Click);
            // 
            // soundRecordingToolStripMenuItem
            // 
            this.soundRecordingToolStripMenuItem.Name = "soundRecordingToolStripMenuItem";
            this.soundRecordingToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.soundRecordingToolStripMenuItem.Text = "Sound Recording";
            this.soundRecordingToolStripMenuItem.Click += new System.EventHandler(this.soundRecordingToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // electronicResourceToolStripMenuItem
            // 
            this.electronicResourceToolStripMenuItem.Name = "electronicResourceToolStripMenuItem";
            this.electronicResourceToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.electronicResourceToolStripMenuItem.Text = "Electronic Resource";
            this.electronicResourceToolStripMenuItem.Click += new System.EventHandler(this.electronicResourceToolStripMenuItem_Click);
            // 
            // mixMaterialToolStripMenuItem
            // 
            this.mixMaterialToolStripMenuItem.Name = "mixMaterialToolStripMenuItem";
            this.mixMaterialToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.mixMaterialToolStripMenuItem.Text = "Mix Material";
            this.mixMaterialToolStripMenuItem.Click += new System.EventHandler(this.mixMaterialToolStripMenuItem_Click);
            // 
            // lnkAssoc
            // 
            this.lnkAssoc.AutoSize = true;
            this.lnkAssoc.ContextMenuStrip = this.contextMenuStrip1;
            this.lnkAssoc.Location = new System.Drawing.Point(32, 233);
            this.lnkAssoc.Name = "lnkAssoc";
            this.lnkAssoc.Size = new System.Drawing.Size(166, 20);
            this.lnkAssoc.TabIndex = 29;
            this.lnkAssoc.TabStop = true;
            this.lnkAssoc.Text = "Associate Templates";
            this.lnkAssoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAssoc_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Actions:";
            // 
            // lnkTemplates
            // 
            this.lnkTemplates.AutoSize = true;
            this.lnkTemplates.ContextMenuStrip = this.contextMenuStrip1;
            this.lnkTemplates.Location = new System.Drawing.Point(32, 253);
            this.lnkTemplates.Name = "lnkTemplates";
            this.lnkTemplates.Size = new System.Drawing.Size(121, 20);
            this.lnkTemplates.TabIndex = 27;
            this.lnkTemplates.TabStop = true;
            this.lnkTemplates.Text = "Edit Templates";
            this.lnkTemplates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTemplates_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 309);
            this.Controls.Add(this.lnkAssoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnkTemplates);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdProcess);
            this.Controls.Add(this.txt_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIS2MARC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_save;
        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartographicResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electronicResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mixMaterialToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkAssoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkTemplates;
    }
}