namespace VRoidHairMerger
{
    partial class MergeForm
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
            this.sourcePreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destPreset = new System.Windows.Forms.ComboBox();
            this.mergeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hairPath = new System.Windows.Forms.Label();
            this.pathChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourcePreset
            // 
            this.sourcePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourcePreset.FormattingEnabled = true;
            this.sourcePreset.Location = new System.Drawing.Point(15, 114);
            this.sourcePreset.Name = "sourcePreset";
            this.sourcePreset.Size = new System.Drawing.Size(197, 21);
            this.sourcePreset.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source preset";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination preset";
            // 
            // destPreset
            // 
            this.destPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destPreset.FormattingEnabled = true;
            this.destPreset.Location = new System.Drawing.Point(266, 114);
            this.destPreset.Name = "destPreset";
            this.destPreset.Size = new System.Drawing.Size(197, 21);
            this.destPreset.TabIndex = 2;
            // 
            // mergeButton
            // 
            this.mergeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeButton.Location = new System.Drawing.Point(358, 161);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(105, 23);
            this.mergeButton.TabIndex = 4;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current hair preset path:";
            // 
            // hairPath
            // 
            this.hairPath.AutoSize = true;
            this.hairPath.Location = new System.Drawing.Point(12, 28);
            this.hairPath.Name = "hairPath";
            this.hairPath.Size = new System.Drawing.Size(28, 13);
            this.hairPath.TabIndex = 6;
            this.hairPath.Text = "path";
            // 
            // pathChangeButton
            // 
            this.pathChangeButton.Location = new System.Drawing.Point(15, 47);
            this.pathChangeButton.Name = "pathChangeButton";
            this.pathChangeButton.Size = new System.Drawing.Size(106, 23);
            this.pathChangeButton.TabIndex = 7;
            this.pathChangeButton.Text = "Change path";
            this.pathChangeButton.UseVisualStyleBackColor = true;
            this.pathChangeButton.Click += new System.EventHandler(this.PathChangeButton_Click);
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 197);
            this.Controls.Add(this.pathChangeButton);
            this.Controls.Add(this.hairPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destPreset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourcePreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MergeForm";
            this.Text = "VRoidHairMerger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourcePreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox destPreset;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hairPath;
        private System.Windows.Forms.Button pathChangeButton;
    }
}

