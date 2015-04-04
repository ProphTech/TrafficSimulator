namespace Traffic_Advisor
{
    partial class Project_Grid_Screen
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
            this.picBox_Grid = new System.Windows.Forms.PictureBox();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Filename = new System.Windows.Forms.Label();
            this.menuStrip_TrafficMenu = new System.Windows.Forms.MenuStrip();
            this.buildMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Statistics = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Grid)).BeginInit();
            this.menuStrip_MainMenu.SuspendLayout();
            this.menuStrip_TrafficMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox_Grid
            // 
            this.picBox_Grid.BackColor = System.Drawing.SystemColors.Desktop;
            this.picBox_Grid.Location = new System.Drawing.Point(0, 27);
            this.picBox_Grid.Name = "picBox_Grid";
            this.picBox_Grid.Size = new System.Drawing.Size(788, 398);
            this.picBox_Grid.TabIndex = 0;
            this.picBox_Grid.TabStop = false;
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(941, 24);
            this.menuStrip_MainMenu.TabIndex = 1;
            this.menuStrip_MainMenu.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSimulationToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.mainScreenToolStripMenuItem,
            this.resetToolStripMenuItem1});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mainMenuToolStripMenuItem.Text = "File menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // newSimulationToolStripMenuItem
            // 
            this.newSimulationToolStripMenuItem.Name = "newSimulationToolStripMenuItem";
            this.newSimulationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSimulationToolStripMenuItem.Text = "New Simulation";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // mainScreenToolStripMenuItem
            // 
            this.mainScreenToolStripMenuItem.Name = "mainScreenToolStripMenuItem";
            this.mainScreenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainScreenToolStripMenuItem.Text = "Main Screen";
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // label_Filename
            // 
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(489, 9);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(54, 13);
            this.label_Filename.TabIndex = 2;
            this.label_Filename.Text = "FileName:";
            // 
            // menuStrip_TrafficMenu
            // 
            this.menuStrip_TrafficMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip_TrafficMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip_TrafficMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildMapToolStripMenuItem,
            this.testRouteToolStripMenuItem});
            this.menuStrip_TrafficMenu.Location = new System.Drawing.Point(941, 0);
            this.menuStrip_TrafficMenu.Name = "menuStrip_TrafficMenu";
            this.menuStrip_TrafficMenu.Size = new System.Drawing.Size(78, 633);
            this.menuStrip_TrafficMenu.TabIndex = 3;
            this.menuStrip_TrafficMenu.Text = "menuStrip1";
            // 
            // buildMapToolStripMenuItem
            // 
            this.buildMapToolStripMenuItem.Name = "buildMapToolStripMenuItem";
            this.buildMapToolStripMenuItem.Size = new System.Drawing.Size(65, 17);
            this.buildMapToolStripMenuItem.Text = "Build map";
            // 
            // testRouteToolStripMenuItem
            // 
            this.testRouteToolStripMenuItem.Name = "testRouteToolStripMenuItem";
            this.testRouteToolStripMenuItem.Size = new System.Drawing.Size(65, 17);
            this.testRouteToolStripMenuItem.Text = "Test Route";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Statistics);
            this.groupBox1.Location = new System.Drawing.Point(0, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Similation Statistics:";
            // 
            // lb_Statistics
            // 
            this.lb_Statistics.FormattingEnabled = true;
            this.lb_Statistics.Location = new System.Drawing.Point(6, 19);
            this.lb_Statistics.Name = "lb_Statistics";
            this.lb_Statistics.Size = new System.Drawing.Size(776, 186);
            this.lb_Statistics.TabIndex = 0;
            // 
            // Project_Grid_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Filename);
            this.Controls.Add(this.picBox_Grid);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Controls.Add(this.menuStrip_TrafficMenu);
            this.MainMenuStrip = this.menuStrip_MainMenu;
            this.Name = "Project_Grid_Screen";
            this.Text = "Project_Grid_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Grid)).EndInit();
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.menuStrip_TrafficMenu.ResumeLayout(false);
            this.menuStrip_TrafficMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Grid;
        private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.MenuStrip menuStrip_TrafficMenu;
        private System.Windows.Forms.ToolStripMenuItem buildMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testRouteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_Statistics;
    }
}