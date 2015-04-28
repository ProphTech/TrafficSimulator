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
            this.label_Filename = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Statistics = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btSetup = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbtypeA = new System.Windows.Forms.PictureBox();
            this.pbtypeB = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeB)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.menuStrip_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Filename
            // 
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(489, 8);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(59, 12);
            this.label_Filename.TabIndex = 2;
            this.label_Filename.Text = "FileName:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Statistics);
            this.groupBox1.Location = new System.Drawing.Point(12, 694);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Similation Statistics:";
            // 
            // lb_Statistics
            // 
            this.lb_Statistics.FormattingEnabled = true;
            this.lb_Statistics.ItemHeight = 12;
            this.lb_Statistics.Location = new System.Drawing.Point(6, 30);
            this.lb_Statistics.Name = "lb_Statistics";
            this.lb_Statistics.Size = new System.Drawing.Size(1067, 112);
            this.lb_Statistics.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btSetup
            // 
            this.btSetup.Location = new System.Drawing.Point(24, 22);
            this.btSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btSetup.Name = "btSetup";
            this.btSetup.Size = new System.Drawing.Size(171, 29);
            this.btSetup.TabIndex = 9;
            this.btSetup.Text = "Set up";
            this.btSetup.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pbtypeA);
            this.groupBox5.Controls.Add(this.pbtypeB);
            this.groupBox5.Location = new System.Drawing.Point(874, 29);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(236, 461);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "crossing";
            // 
            // pbtypeA
            // 
            this.pbtypeA.Image = global::Traffic_Advisor.Properties.Resources.typeA;
            this.pbtypeA.Location = new System.Drawing.Point(19, 21);
            this.pbtypeA.Name = "pbtypeA";
            this.pbtypeA.Size = new System.Drawing.Size(200, 200);
            this.pbtypeA.TabIndex = 5;
            this.pbtypeA.TabStop = false;
            this.pbtypeA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbtypeA_MouseDown);
            // 
            // pbtypeB
            // 
            this.pbtypeB.Image = global::Traffic_Advisor.Properties.Resources.typeB;
            this.pbtypeB.Location = new System.Drawing.Point(19, 242);
            this.pbtypeB.Name = "pbtypeB";
            this.pbtypeB.Size = new System.Drawing.Size(200, 200);
            this.pbtypeB.TabIndex = 6;
            this.pbtypeB.TabStop = false;
            this.pbtypeB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbtypeB_MouseClick);
            this.pbtypeB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbtypeB_MouseDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btSetup);
            this.groupBox6.Controls.Add(this.btPlay);
            this.groupBox6.Controls.Add(this.btStop);
            this.groupBox6.Location = new System.Drawing.Point(890, 508);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(203, 124);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Controls";
            // 
            // btPlay
            // 
            this.btPlay.BackgroundImage = global::Traffic_Advisor.Properties.Resources.play;
            this.btPlay.Location = new System.Drawing.Point(49, 59);
            this.btPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(47, 46);
            this.btPlay.TabIndex = 7;
            this.btPlay.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.BackgroundImage = global::Traffic_Advisor.Properties.Resources.stop;
            this.btStop.Location = new System.Drawing.Point(124, 59);
            this.btStop.Margin = new System.Windows.Forms.Padding(4);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(47, 46);
            this.btStop.TabIndex = 8;
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // pbGrid
            // 
            this.pbGrid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbGrid.Location = new System.Drawing.Point(20, 50);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(800, 600);
            this.pbGrid.TabIndex = 11;
            this.pbGrid.TabStop = false;
            this.pbGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbGird_DragDrop);
            this.pbGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbGird_DragEnter);
            this.pbGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGird_Paint);
            this.pbGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGird_MouseClick);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSimulationToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.mainScreenToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.mainMenuToolStripMenuItem.Text = "File menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // newSimulationToolStripMenuItem
            // 
            this.newSimulationToolStripMenuItem.Name = "newSimulationToolStripMenuItem";
            this.newSimulationToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newSimulationToolStripMenuItem.Text = "New Simulation";
            this.newSimulationToolStripMenuItem.Click += new System.EventHandler(this.newSimulationToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // mainScreenToolStripMenuItem
            // 
            this.mainScreenToolStripMenuItem.Name = "mainScreenToolStripMenuItem";
            this.mainScreenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.mainScreenToolStripMenuItem.Text = "Main Screen";
            this.mainScreenToolStripMenuItem.Click += new System.EventHandler(this.mainScreenToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateToolStripMenuItem,
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.controlToolStripMenuItem.Text = "Control";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.redoToolStripMenuItem1.Text = "Redo";
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(1123, 25);
            this.menuStrip_MainMenu.TabIndex = 1;
            this.menuStrip_MainMenu.Text = "menuStrip1";
            // 
            // Project_Grid_Screen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 862);
            this.Controls.Add(this.pbGrid);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Filename);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.MainMenuStrip = this.menuStrip_MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1139, 900);
            this.MinimumSize = new System.Drawing.Size(1139, 900);
            this.Name = "Project_Grid_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project_Grid_Screen";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Project_Grid_Screen_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Project_Grid_Screen_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Project_Grid_Screen_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeB)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_Statistics;
        private System.Windows.Forms.PictureBox pbtypeA;
        private System.Windows.Forms.PictureBox pbtypeB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btSetup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
    }
}