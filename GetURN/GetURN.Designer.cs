namespace GetURN
{
    partial class GetURN
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
            this.lblForgeClientID = new System.Windows.Forms.Label();
            this.lblForgeClientSecret = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tbxForgeClientId = new System.Windows.Forms.TextBox();
            this.tbxForgeClientSecret = new System.Windows.Forms.TextBox();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.lblURN = new System.Windows.Forms.Label();
            this.btnGetURN = new System.Windows.Forms.Button();
            this.btnLaunchHTML = new System.Windows.Forms.Button();
            this.pbrProcessProgress = new System.Windows.Forms.ProgressBar();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.tbxNewURN = new System.Windows.Forms.TextBox();
            this.btnUpdateDefaults = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxCopyToClipboard = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCopyToClipboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgeClientID
            // 
            this.lblForgeClientID.AutoSize = true;
            this.lblForgeClientID.Location = new System.Drawing.Point(14, 22);
            this.lblForgeClientID.Name = "lblForgeClientID";
            this.lblForgeClientID.Size = new System.Drawing.Size(59, 13);
            this.lblForgeClientID.TabIndex = 0;
            this.lblForgeClientID.Text = "CLIENT ID";
            // 
            // lblForgeClientSecret
            // 
            this.lblForgeClientSecret.AutoSize = true;
            this.lblForgeClientSecret.Location = new System.Drawing.Point(14, 48);
            this.lblForgeClientSecret.Name = "lblForgeClientSecret";
            this.lblForgeClientSecret.Size = new System.Drawing.Size(91, 13);
            this.lblForgeClientSecret.TabIndex = 1;
            this.lblForgeClientSecret.Text = "CLIENT SECRET";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 117);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(55, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "FIle Name";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 143);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "File Path";
            // 
            // tbxForgeClientId
            // 
            this.tbxForgeClientId.Location = new System.Drawing.Point(126, 15);
            this.tbxForgeClientId.Name = "tbxForgeClientId";
            this.tbxForgeClientId.Size = new System.Drawing.Size(371, 20);
            this.tbxForgeClientId.TabIndex = 4;
            // 
            // tbxForgeClientSecret
            // 
            this.tbxForgeClientSecret.Location = new System.Drawing.Point(126, 45);
            this.tbxForgeClientSecret.Name = "tbxForgeClientSecret";
            this.tbxForgeClientSecret.Size = new System.Drawing.Size(144, 20);
            this.tbxForgeClientSecret.TabIndex = 5;
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(141, 114);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(225, 20);
            this.tbxFileName.TabIndex = 6;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(141, 140);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(639, 20);
            this.tbxFilePath.TabIndex = 7;
            // 
            // lblURN
            // 
            this.lblURN.AutoSize = true;
            this.lblURN.Location = new System.Drawing.Point(12, 234);
            this.lblURN.Name = "lblURN";
            this.lblURN.Size = new System.Drawing.Size(59, 13);
            this.lblURN.TabIndex = 8;
            this.lblURN.Text = "New URN:";
            // 
            // btnGetURN
            // 
            this.btnGetURN.Location = new System.Drawing.Point(141, 190);
            this.btnGetURN.Name = "btnGetURN";
            this.btnGetURN.Size = new System.Drawing.Size(75, 23);
            this.btnGetURN.TabIndex = 10;
            this.btnGetURN.Text = "Get URN";
            this.btnGetURN.UseVisualStyleBackColor = true;
            this.btnGetURN.Click += new System.EventHandler(this.btnGetURN_Click);
            // 
            // btnLaunchHTML
            // 
            this.btnLaunchHTML.Enabled = false;
            this.btnLaunchHTML.Location = new System.Drawing.Point(15, 260);
            this.btnLaunchHTML.Name = "btnLaunchHTML";
            this.btnLaunchHTML.Size = new System.Drawing.Size(104, 23);
            this.btnLaunchHTML.TabIndex = 11;
            this.btnLaunchHTML.Text = "Launch HTML";
            this.btnLaunchHTML.UseVisualStyleBackColor = true;
            this.btnLaunchHTML.Click += new System.EventHandler(this.btnLaunchHTML_Click);
            // 
            // pbrProcessProgress
            // 
            this.pbrProcessProgress.Location = new System.Drawing.Point(222, 201);
            this.pbrProcessProgress.Name = "pbrProcessProgress";
            this.pbrProcessProgress.Size = new System.Drawing.Size(288, 12);
            this.pbrProcessProgress.TabIndex = 12;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(389, 112);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(73, 23);
            this.btnDeleteFile.TabIndex = 13;
            this.btnDeleteFile.Text = "Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // tbxNewURN
            // 
            this.tbxNewURN.Enabled = false;
            this.tbxNewURN.Location = new System.Drawing.Point(77, 231);
            this.tbxNewURN.Name = "tbxNewURN";
            this.tbxNewURN.Size = new System.Drawing.Size(703, 20);
            this.tbxNewURN.TabIndex = 14;
            // 
            // btnUpdateDefaults
            // 
            this.btnUpdateDefaults.Location = new System.Drawing.Point(573, 19);
            this.btnUpdateDefaults.Name = "btnUpdateDefaults";
            this.btnUpdateDefaults.Size = new System.Drawing.Size(133, 23);
            this.btnUpdateDefaults.TabIndex = 15;
            this.btnUpdateDefaults.Text = "Update Defaults";
            this.btnUpdateDefaults.UseVisualStyleBackColor = true;
            this.btnUpdateDefaults.Click += new System.EventHandler(this.btnUpdateDefaults_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxForgeClientId);
            this.groupBox1.Controls.Add(this.btnUpdateDefaults);
            this.groupBox1.Controls.Add(this.lblForgeClientID);
            this.groupBox1.Controls.Add(this.lblForgeClientSecret);
            this.groupBox1.Controls.Add(this.tbxForgeClientSecret);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 89);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forge Details";
            // 
            // pbxCopyToClipboard
            // 
            this.pbxCopyToClipboard.BackgroundImage = global::GetURN.Properties.Resources.copy1;
            this.pbxCopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCopyToClipboard.InitialImage = global::GetURN.Properties.Resources.copy;
            this.pbxCopyToClipboard.Location = new System.Drawing.Point(786, 231);
            this.pbxCopyToClipboard.Name = "pbxCopyToClipboard";
            this.pbxCopyToClipboard.Size = new System.Drawing.Size(27, 20);
            this.pbxCopyToClipboard.TabIndex = 17;
            this.pbxCopyToClipboard.TabStop = false;
            this.pbxCopyToClipboard.Click += new System.EventHandler(this.pbxCopyToClipboard_Click);
            // 
            // GetURN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 296);
            this.Controls.Add(this.pbxCopyToClipboard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxNewURN);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.pbrProcessProgress);
            this.Controls.Add(this.btnLaunchHTML);
            this.Controls.Add(this.btnGetURN);
            this.Controls.Add(this.lblURN);
            this.Controls.Add(this.tbxFilePath);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblFileName);
            this.Name = "GetURN";
            this.Text = "Get URN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCopyToClipboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgeClientID;
        private System.Windows.Forms.Label lblForgeClientSecret;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox tbxForgeClientId;
        private System.Windows.Forms.TextBox tbxForgeClientSecret;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Label lblURN;
        private System.Windows.Forms.Button btnGetURN;
        private System.Windows.Forms.Button btnLaunchHTML;
        private System.Windows.Forms.ProgressBar pbrProcessProgress;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.TextBox tbxNewURN;
        private System.Windows.Forms.Button btnUpdateDefaults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxCopyToClipboard;
    }
}

