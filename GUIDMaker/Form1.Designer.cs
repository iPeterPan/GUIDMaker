namespace GUIDMaker
{
    partial class frmGUIDMaker
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtGUIDs = new System.Windows.Forms.TextBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(580, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMake
            // 
            this.btnMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMake.Location = new System.Drawing.Point(280, 643);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(144, 41);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(430, 643);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(144, 41);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtGUIDs
            // 
            this.txtGUIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGUIDs.Location = new System.Drawing.Point(12, 15);
            this.txtGUIDs.Multiline = true;
            this.txtGUIDs.Name = "txtGUIDs";
            this.txtGUIDs.Size = new System.Drawing.Size(712, 614);
            this.txtGUIDs.TabIndex = 1;
            // 
            // nudCount
            // 
            this.nudCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCount.Location = new System.Drawing.Point(101, 651);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(162, 32);
            this.nudCount.TabIndex = 2;
            this.nudCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count :";
            // 
            // frmGUIDMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.txtGUIDs);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 760);
            this.Name = "frmGUIDMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID Maker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtGUIDs;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label1;
    }
}

