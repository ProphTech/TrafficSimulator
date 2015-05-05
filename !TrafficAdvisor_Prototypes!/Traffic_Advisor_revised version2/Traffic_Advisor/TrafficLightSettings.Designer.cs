namespace Traffic_Advisor
{
    partial class TrafficLightSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficLightSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.btCompelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYellow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Interval:";
            // 
            // btCompelete
            // 
            this.btCompelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCompelete.Font = new System.Drawing.Font("叶根友毛笔行书2.0版", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCompelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btCompelete.Location = new System.Drawing.Point(427, 25);
            this.btCompelete.Name = "btCompelete";
            this.btCompelete.Size = new System.Drawing.Size(131, 36);
            this.btCompelete.TabIndex = 19;
            this.btCompelete.Text = "complete";
            this.btCompelete.UseVisualStyleBackColor = false;
            this.btCompelete.Click += new System.EventHandler(this.btCompelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(195, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(259, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(332, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(195, 53);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownRed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.ReadOnly = true;
            this.numericUpDownRed.Size = new System.Drawing.Size(37, 21);
            this.numericUpDownRed.TabIndex = 33;
            this.numericUpDownRed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownYellow
            // 
            this.numericUpDownYellow.Location = new System.Drawing.Point(259, 53);
            this.numericUpDownYellow.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownYellow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYellow.Name = "numericUpDownYellow";
            this.numericUpDownYellow.ReadOnly = true;
            this.numericUpDownYellow.Size = new System.Drawing.Size(37, 21);
            this.numericUpDownYellow.TabIndex = 34;
            this.numericUpDownYellow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(332, 53);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownGreen.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.ReadOnly = true;
            this.numericUpDownGreen.Size = new System.Drawing.Size(37, 21);
            this.numericUpDownGreen.TabIndex = 35;
            this.numericUpDownGreen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TrafficLightSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 86);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownYellow);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCompelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrafficLightSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Light Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrafficLightSettings_FormClosing);
            this.Load += new System.EventHandler(this.TrafficLightSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCompelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownYellow;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;

    }
}