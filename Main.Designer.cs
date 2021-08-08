namespace ExamplePacketPlugin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.lblHide = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblClearLog = new System.Windows.Forms.LinkLabel();
            this.numHH = new ExamplePacketPlugin.MyNumericUpDown();
            this.numMM = new ExamplePacketPlugin.MyNumericUpDown();
            this.numSS = new ExamplePacketPlugin.MyNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(12, 70);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(59, 17);
            this.cbEnable.TabIndex = 2;
            this.cbEnable.Text = "Enable";
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adlinnaka Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adlinnaka Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(69, 72);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(49, 13);
            this.lbTimer.TabIndex = 9;
            this.lbTimer.Text = "{Timer}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "HH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SS";
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(12, 102);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(166, 84);
            this.tbLog.TabIndex = 13;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(140, 71);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(35, 13);
            this.lblHide.TabIndex = 14;
            this.lblHide.TabStop = true;
            this.lblHide.Text = "[Hide]";
            this.lblHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHide_LinkClicked);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblClearLog
            // 
            this.lblClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearLog.AutoSize = true;
            this.lblClearLog.Location = new System.Drawing.Point(123, 189);
            this.lblClearLog.Name = "lblClearLog";
            this.lblClearLog.Size = new System.Drawing.Size(55, 13);
            this.lblClearLog.TabIndex = 15;
            this.lblClearLog.TabStop = true;
            this.lblClearLog.Text = "[ClearLog]";
            this.lblClearLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClearLog_LinkClicked);
            // 
            // numHH
            // 
            this.numHH.Location = new System.Drawing.Point(12, 35);
            this.numHH.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHH.Name = "numHH";
            this.numHH.Size = new System.Drawing.Size(39, 20);
            this.numHH.TabIndex = 7;
            // 
            // numMM
            // 
            this.numMM.Location = new System.Drawing.Point(73, 35);
            this.numMM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMM.Name = "numMM";
            this.numMM.Size = new System.Drawing.Size(39, 20);
            this.numMM.TabIndex = 5;
            this.numMM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numSS
            // 
            this.numSS.Location = new System.Drawing.Point(134, 35);
            this.numSS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSS.Name = "numSS";
            this.numSS.Size = new System.Drawing.Size(39, 20);
            this.numSS.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 209);
            this.Controls.Add(this.lblClearLog);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.numHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSS);
            this.Controls.Add(this.cbEnable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logout Every";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbEnable;
        private MyNumericUpDown numSS;
        private System.Windows.Forms.Label label1;
        private MyNumericUpDown numMM;
        private System.Windows.Forms.Label label2;
        private MyNumericUpDown numHH;
        public System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.LinkLabel lblHide;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.LinkLabel lblClearLog;
    }
}