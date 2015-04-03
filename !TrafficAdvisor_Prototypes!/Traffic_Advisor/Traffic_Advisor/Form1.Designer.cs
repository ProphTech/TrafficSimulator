namespace Traffic_Advisor
{
    partial class MainScreen
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
            this.butt_OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butt_LoadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butt_OpenFile
            // 
            this.butt_OpenFile.Location = new System.Drawing.Point(42, 170);
            this.butt_OpenFile.Name = "butt_OpenFile";
            this.butt_OpenFile.Size = new System.Drawing.Size(75, 38);
            this.butt_OpenFile.TabIndex = 0;
            this.butt_OpenFile.Text = "button1";
            this.butt_OpenFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open File:";
            // 
            // butt_LoadFile
            // 
            this.butt_LoadFile.Location = new System.Drawing.Point(168, 170);
            this.butt_LoadFile.Name = "butt_LoadFile";
            this.butt_LoadFile.Size = new System.Drawing.Size(75, 38);
            this.butt_LoadFile.TabIndex = 2;
            this.butt_LoadFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Simulation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to Traffic Advisor";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butt_LoadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_OpenFile);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_OpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_LoadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

