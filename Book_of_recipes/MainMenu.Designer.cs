namespace Book_of_recipes
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CookTimeValue = new System.Windows.Forms.Label();
            this.PreparationTimeValue = new System.Windows.Forms.Label();
            this.CookTimeLabel = new System.Windows.Forms.Label();
            this.PreparationTimeLabel = new System.Windows.Forms.Label();
            this.Label_RecipeName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1MinSize = 140;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Wheat;
            this.splitContainer1.Panel2.Controls.Add(this.DescriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(995, 553);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(328, 527);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Wheat;
            this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(0, 370);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(656, 181);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CookTimeValue);
            this.panel1.Controls.Add(this.PreparationTimeValue);
            this.panel1.Controls.Add(this.CookTimeLabel);
            this.panel1.Controls.Add(this.PreparationTimeLabel);
            this.panel1.Controls.Add(this.Label_RecipeName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 370);
            this.panel1.TabIndex = 2;
            // 
            // CookTimeValue
            // 
            this.CookTimeValue.AutoSize = true;
            this.CookTimeValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CookTimeValue.Location = new System.Drawing.Point(147, 347);
            this.CookTimeValue.Name = "CookTimeValue";
            this.CookTimeValue.Size = new System.Drawing.Size(20, 24);
            this.CookTimeValue.TabIndex = 5;
            this.CookTimeValue.Text = "0";
            // 
            // PreparationTimeValue
            // 
            this.PreparationTimeValue.AutoSize = true;
            this.PreparationTimeValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreparationTimeValue.Location = new System.Drawing.Point(147, 320);
            this.PreparationTimeValue.Name = "PreparationTimeValue";
            this.PreparationTimeValue.Size = new System.Drawing.Size(20, 24);
            this.PreparationTimeValue.TabIndex = 4;
            this.PreparationTimeValue.Text = "0";
            // 
            // CookTimeLabel
            // 
            this.CookTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CookTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CookTimeLabel.Location = new System.Drawing.Point(0, 346);
            this.CookTimeLabel.Name = "CookTimeLabel";
            this.CookTimeLabel.Size = new System.Drawing.Size(146, 25);
            this.CookTimeLabel.TabIndex = 3;
            this.CookTimeLabel.Text = "Coocking time:";
            this.CookTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PreparationTimeLabel
            // 
            this.PreparationTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PreparationTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreparationTimeLabel.Location = new System.Drawing.Point(-3, 316);
            this.PreparationTimeLabel.Name = "PreparationTimeLabel";
            this.PreparationTimeLabel.Size = new System.Drawing.Size(166, 25);
            this.PreparationTimeLabel.TabIndex = 2;
            this.PreparationTimeLabel.Text = "Preparation time:";
            this.PreparationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_RecipeName
            // 
            this.Label_RecipeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_RecipeName.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_RecipeName.Location = new System.Drawing.Point(193, 316);
            this.Label_RecipeName.Name = "Label_RecipeName";
            this.Label_RecipeName.Size = new System.Drawing.Size(452, 51);
            this.Label_RecipeName.TabIndex = 1;
            this.Label_RecipeName.Text = "Text";
            this.Label_RecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_RecipeName.Click += new System.EventHandler(this.Lable_RecipeName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(995, 553);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(565, 600);
            this.Name = "MainMenu";
            this.Text = "app";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label Label_RecipeName;
        private TreeView treeView1;
        private Panel panel1;
        private TextBox DescriptionTextBox;
        private Label CookTimeLabel;
        private Label PreparationTimeLabel;
        private Label CookTimeValue;
        private Label PreparationTimeValue;
        private MenuStrip menuStrip1;
    }
}