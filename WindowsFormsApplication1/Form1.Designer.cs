namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simLogTextBox = new System.Windows.Forms.TextBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.dayLabel = new System.Windows.Forms.Label();
            this.timeOfDayLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSimulationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSimulationToolStripMenuItem
            // 
            this.newSimulationToolStripMenuItem.Name = "newSimulationToolStripMenuItem";
            this.newSimulationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newSimulationToolStripMenuItem.Text = "New Simulation";
            this.newSimulationToolStripMenuItem.Click += new System.EventHandler(this.newSimulationToolStripMenuItem_Click);
            // 
            // simLogTextBox
            // 
            this.simLogTextBox.Location = new System.Drawing.Point(35, 57);
            this.simLogTextBox.Multiline = true;
            this.simLogTextBox.Name = "simLogTextBox";
            this.simLogTextBox.ReadOnly = true;
            this.simLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.simLogTextBox.Size = new System.Drawing.Size(700, 410);
            this.simLogTextBox.TabIndex = 1;
            this.simLogTextBox.TextChanged += new System.EventHandler(this.simLogTextBox_TextChanged);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 3000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(635, 28);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(50, 13);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "dayLabel";
            this.dayLabel.Visible = false;
            // 
            // timeOfDayLabel
            // 
            this.timeOfDayLabel.AutoSize = true;
            this.timeOfDayLabel.Location = new System.Drawing.Point(676, 28);
            this.timeOfDayLabel.Name = "timeOfDayLabel";
            this.timeOfDayLabel.Size = new System.Drawing.Size(82, 13);
            this.timeOfDayLabel.TabIndex = 3;
            this.timeOfDayLabel.Text = "timeOfDayLabel";
            this.timeOfDayLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.timeOfDayLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.simLogTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label timeOfDayLabel;
        public System.Windows.Forms.ToolStripMenuItem newSimulationToolStripMenuItem;
        public System.Windows.Forms.TextBox simLogTextBox;
    }
}

