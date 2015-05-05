namespace Traffic_Advisor
{
    partial class CrossingEditer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossingEditer));
            this.btCompelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMaxUp1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxUp2 = new System.Windows.Forms.TextBox();
            this.tbMaxD2 = new System.Windows.Forms.TextBox();
            this.tbMaxD1 = new System.Windows.Forms.TextBox();
            this.tbMaxL2 = new System.Windows.Forms.TextBox();
            this.tbMaxL1 = new System.Windows.Forms.TextBox();
            this.tbMaxR2 = new System.Windows.Forms.TextBox();
            this.tbMaxR1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCompelete
            // 
            this.btCompelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCompelete.Font = new System.Drawing.Font("叶根友毛笔行书2.0版", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCompelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btCompelete.Location = new System.Drawing.Point(443, 299);
            this.btCompelete.Name = "btCompelete";
            this.btCompelete.Size = new System.Drawing.Size(131, 36);
            this.btCompelete.TabIndex = 0;
            this.btCompelete.Text = "complete";
            this.btCompelete.UseVisualStyleBackColor = false;
            this.btCompelete.Click += new System.EventHandler(this.btCompelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Traffic_Advisor.Properties.Resources.typeA;
            this.pictureBox1.Location = new System.Drawing.Point(195, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbMaxUp1
            // 
            this.tbMaxUp1.Location = new System.Drawing.Point(247, 33);
            this.tbMaxUp1.MaxLength = 2;
            this.tbMaxUp1.Name = "tbMaxUp1";
            this.tbMaxUp1.Size = new System.Drawing.Size(20, 21);
            this.tbMaxUp1.TabIndex = 2;
            this.tbMaxUp1.Text = "20";
            this.tbMaxUp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxUp1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum flow:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum flow:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maximum flow:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maximum flow:";
            // 
            // tbMaxUp2
            // 
            this.tbMaxUp2.Location = new System.Drawing.Point(273, 33);
            this.tbMaxUp2.MaxLength = 2;
            this.tbMaxUp2.Name = "tbMaxUp2";
            this.tbMaxUp2.Size = new System.Drawing.Size(20, 21);
            this.tbMaxUp2.TabIndex = 12;
            this.tbMaxUp2.Text = "20";
            this.tbMaxUp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxUp2_KeyPress);
            // 
            // tbMaxD2
            // 
            this.tbMaxD2.Location = new System.Drawing.Point(318, 290);
            this.tbMaxD2.MaxLength = 2;
            this.tbMaxD2.Name = "tbMaxD2";
            this.tbMaxD2.Size = new System.Drawing.Size(20, 21);
            this.tbMaxD2.TabIndex = 14;
            this.tbMaxD2.Text = "20";
            this.tbMaxD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxD2_KeyPress);
            // 
            // tbMaxD1
            // 
            this.tbMaxD1.Location = new System.Drawing.Point(292, 290);
            this.tbMaxD1.MaxLength = 2;
            this.tbMaxD1.Name = "tbMaxD1";
            this.tbMaxD1.Size = new System.Drawing.Size(20, 21);
            this.tbMaxD1.TabIndex = 13;
            this.tbMaxD1.Text = "20";
            this.tbMaxD1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxD1_KeyPress);
            // 
            // tbMaxL2
            // 
            this.tbMaxL2.Location = new System.Drawing.Point(169, 177);
            this.tbMaxL2.MaxLength = 2;
            this.tbMaxL2.Name = "tbMaxL2";
            this.tbMaxL2.Size = new System.Drawing.Size(20, 21);
            this.tbMaxL2.TabIndex = 16;
            this.tbMaxL2.Text = "20";
            this.tbMaxL2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxL2_KeyPress);
            // 
            // tbMaxL1
            // 
            this.tbMaxL1.Location = new System.Drawing.Point(169, 150);
            this.tbMaxL1.MaxLength = 2;
            this.tbMaxL1.Name = "tbMaxL1";
            this.tbMaxL1.Size = new System.Drawing.Size(20, 21);
            this.tbMaxL1.TabIndex = 15;
            this.tbMaxL1.Text = "20";
            this.tbMaxL1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxL1_KeyPress);
            // 
            // tbMaxR2
            // 
            this.tbMaxR2.Location = new System.Drawing.Point(415, 138);
            this.tbMaxR2.MaxLength = 2;
            this.tbMaxR2.Name = "tbMaxR2";
            this.tbMaxR2.Size = new System.Drawing.Size(20, 21);
            this.tbMaxR2.TabIndex = 18;
            this.tbMaxR2.Text = "20";
            this.tbMaxR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxR2_KeyPress);
            // 
            // tbMaxR1
            // 
            this.tbMaxR1.Location = new System.Drawing.Point(415, 111);
            this.tbMaxR1.MaxLength = 2;
            this.tbMaxR1.Name = "tbMaxR1";
            this.tbMaxR1.Size = new System.Drawing.Size(20, 21);
            this.tbMaxR1.TabIndex = 17;
            this.tbMaxR1.Text = "20";
            this.tbMaxR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxR1_KeyPress);
            // 
            // CrossingEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 347);
            this.Controls.Add(this.tbMaxR2);
            this.Controls.Add(this.tbMaxR1);
            this.Controls.Add(this.tbMaxL2);
            this.Controls.Add(this.tbMaxL1);
            this.Controls.Add(this.tbMaxD2);
            this.Controls.Add(this.tbMaxD1);
            this.Controls.Add(this.tbMaxUp2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaxUp1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCompelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 385);
            this.MinimumSize = new System.Drawing.Size(602, 385);
            this.Name = "CrossingEditer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossing Editer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrossingEditer_FormClosing);
            this.Load += new System.EventHandler(this.CrossingEditer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCompelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbMaxUp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxUp2;
        private System.Windows.Forms.TextBox tbMaxD2;
        private System.Windows.Forms.TextBox tbMaxD1;
        private System.Windows.Forms.TextBox tbMaxL2;
        private System.Windows.Forms.TextBox tbMaxL1;
        private System.Windows.Forms.TextBox tbMaxR2;
        private System.Windows.Forms.TextBox tbMaxR1;

    }
}