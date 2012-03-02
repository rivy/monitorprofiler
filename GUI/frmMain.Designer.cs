namespace MonitorProfiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIdentifyMonitor = new System.Windows.Forms.Button();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.barBlue = new System.Windows.Forms.TrackBar();
            this.barGreen = new System.Windows.Forms.TrackBar();
            this.barRed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMonitors = new System.Windows.Forms.ComboBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContrast = new System.Windows.Forms.Label();
            this.barContrast = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.barBrightness = new System.Windows.Forms.TrackBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profiles";
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Location = new System.Drawing.Point(78, 182);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(60, 23);
            this.btnNewProfile.TabIndex = 3;
            this.btnNewProfile.Text = "New...";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(12, 182);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(60, 23);
            this.btnSaveProfile.TabIndex = 1;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(12, 211);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(60, 23);
            this.btnDeleteProfile.TabIndex = 2;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnIdentifyMonitor);
            this.groupBox1.Controls.Add(this.lblBlue);
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.barBlue);
            this.groupBox1.Controls.Add(this.barGreen);
            this.groupBox1.Controls.Add(this.barRed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMonitors);
            this.groupBox1.Controls.Add(this.btnRevert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblContrast);
            this.groupBox1.Controls.Add(this.barContrast);
            this.groupBox1.Controls.Add(this.lblBrightness);
            this.groupBox1.Controls.Add(this.barBrightness);
            this.groupBox1.Location = new System.Drawing.Point(144, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 245);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnIdentifyMonitor
            // 
            this.btnIdentifyMonitor.Location = new System.Drawing.Point(379, 11);
            this.btnIdentifyMonitor.Name = "btnIdentifyMonitor";
            this.btnIdentifyMonitor.Size = new System.Drawing.Size(36, 23);
            this.btnIdentifyMonitor.TabIndex = 17;
            this.btnIdentifyMonitor.Text = "?";
            this.btnIdentifyMonitor.UseVisualStyleBackColor = true;
            this.btnIdentifyMonitor.Click += new System.EventHandler(this.btnIdentifyMonitor_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(331, 148);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(39, 18);
            this.lblBlue.TabIndex = 16;
            this.lblBlue.Text = "0%";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(194, 148);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 18);
            this.lblGreen.TabIndex = 15;
            this.lblGreen.Text = "0%";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblRed
            // 
            this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(52, 148);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(39, 18);
            this.lblRed.TabIndex = 14;
            this.lblRed.Text = "0%";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // barBlue
            // 
            this.barBlue.Location = new System.Drawing.Point(285, 169);
            this.barBlue.Name = "barBlue";
            this.barBlue.Size = new System.Drawing.Size(130, 40);
            this.barBlue.TabIndex = 13;
            this.barBlue.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // barGreen
            // 
            this.barGreen.Location = new System.Drawing.Point(148, 169);
            this.barGreen.Name = "barGreen";
            this.barGreen.Size = new System.Drawing.Size(130, 40);
            this.barGreen.TabIndex = 12;
            this.barGreen.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // barRed
            // 
            this.barRed.Location = new System.Drawing.Point(6, 169);
            this.barRed.Name = "barRed";
            this.barRed.Size = new System.Drawing.Size(130, 40);
            this.barRed.TabIndex = 11;
            this.barRed.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monitor";
            // 
            // cboMonitors
            // 
            this.cboMonitors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonitors.FormattingEnabled = true;
            this.cboMonitors.Location = new System.Drawing.Point(99, 13);
            this.cboMonitors.Name = "cboMonitors";
            this.cboMonitors.Size = new System.Drawing.Size(274, 21);
            this.cboMonitors.TabIndex = 9;
            this.cboMonitors.SelectedIndexChanged += new System.EventHandler(this.cboMonitors_SelectedIndexChanged);
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.Location = new System.Drawing.Point(340, 216);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(75, 23);
            this.btnRevert.TabIndex = 7;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contrast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brightness";
            // 
            // lblContrast
            // 
            this.lblContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast.Location = new System.Drawing.Point(376, 86);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(39, 23);
            this.lblContrast.TabIndex = 4;
            this.lblContrast.Text = "0%";
            // 
            // barContrast
            // 
            this.barContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barContrast.Enabled = false;
            this.barContrast.LargeChange = 10;
            this.barContrast.Location = new System.Drawing.Point(99, 98);
            this.barContrast.Maximum = 100;
            this.barContrast.Name = "barContrast";
            this.barContrast.Size = new System.Drawing.Size(271, 40);
            this.barContrast.TabIndex = 3;
            this.barContrast.TickFrequency = 10;
            this.barContrast.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.Location = new System.Drawing.Point(376, 52);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(39, 23);
            this.lblBrightness.TabIndex = 2;
            this.lblBrightness.Text = "0%";
            // 
            // barBrightness
            // 
            this.barBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barBrightness.Enabled = false;
            this.barBrightness.LargeChange = 10;
            this.barBrightness.Location = new System.Drawing.Point(99, 49);
            this.barBrightness.Maximum = 100;
            this.barBrightness.Name = "barBrightness";
            this.barBrightness.Size = new System.Drawing.Size(271, 40);
            this.barBrightness.TabIndex = 1;
            this.barBrightness.TickFrequency = 10;
            this.barBrightness.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 254);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(553, 89);
            this.txtLog.TabIndex = 6;
            // 
            // lstProfiles
            // 
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.Location = new System.Drawing.Point(12, 25);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(126, 147);
            this.lstProfiles.TabIndex = 7;
            this.lstProfiles.SelectedValueChanged += new System.EventHandler(this.lstProfiles_SelectedValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 355);
            this.Controls.Add(this.lstProfiles);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "MonitorProfiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar barBrightness;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.TrackBar barContrast;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMonitors;
        private System.Windows.Forms.TrackBar barRed;
        private System.Windows.Forms.TrackBar barBlue;
        private System.Windows.Forms.TrackBar barGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.Button btnIdentifyMonitor;

    }
}

