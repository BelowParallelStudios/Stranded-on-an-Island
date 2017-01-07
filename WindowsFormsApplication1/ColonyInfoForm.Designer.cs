namespace WindowsFormsApplication1
{
    partial class ColonyInfoForm
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
            this.colonyNameLabel = new System.Windows.Forms.Label();
            this.woodLabel = new System.Windows.Forms.Label();
            this.woodQuantityLabel = new System.Windows.Forms.Label();
            this.stoneQuantityLabel = new System.Windows.Forms.Label();
            this.stoneLabel = new System.Windows.Forms.Label();
            this.foodQuantityLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.blueprintsTextBox = new System.Windows.Forms.TextBox();
            this.blueprintsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colonyNameLabel
            // 
            this.colonyNameLabel.AutoSize = true;
            this.colonyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonyNameLabel.Location = new System.Drawing.Point(13, 13);
            this.colonyNameLabel.Name = "colonyNameLabel";
            this.colonyNameLabel.Size = new System.Drawing.Size(131, 20);
            this.colonyNameLabel.TabIndex = 0;
            this.colonyNameLabel.Text = "Unnamed Colony";
            // 
            // woodLabel
            // 
            this.woodLabel.AutoSize = true;
            this.woodLabel.Location = new System.Drawing.Point(17, 65);
            this.woodLabel.Name = "woodLabel";
            this.woodLabel.Size = new System.Drawing.Size(39, 13);
            this.woodLabel.TabIndex = 1;
            this.woodLabel.Text = "Wood:";
            // 
            // woodQuantityLabel
            // 
            this.woodQuantityLabel.AutoSize = true;
            this.woodQuantityLabel.Location = new System.Drawing.Point(63, 65);
            this.woodQuantityLabel.Name = "woodQuantityLabel";
            this.woodQuantityLabel.Size = new System.Drawing.Size(21, 13);
            this.woodQuantityLabel.TabIndex = 2;
            this.woodQuantityLabel.Text = "##";
            // 
            // stoneQuantityLabel
            // 
            this.stoneQuantityLabel.AutoSize = true;
            this.stoneQuantityLabel.Location = new System.Drawing.Point(63, 89);
            this.stoneQuantityLabel.Name = "stoneQuantityLabel";
            this.stoneQuantityLabel.Size = new System.Drawing.Size(21, 13);
            this.stoneQuantityLabel.TabIndex = 4;
            this.stoneQuantityLabel.Text = "##";
            // 
            // stoneLabel
            // 
            this.stoneLabel.AutoSize = true;
            this.stoneLabel.Location = new System.Drawing.Point(17, 89);
            this.stoneLabel.Name = "stoneLabel";
            this.stoneLabel.Size = new System.Drawing.Size(38, 13);
            this.stoneLabel.TabIndex = 3;
            this.stoneLabel.Text = "Stone:";
            // 
            // foodQuantityLabel
            // 
            this.foodQuantityLabel.AutoSize = true;
            this.foodQuantityLabel.Location = new System.Drawing.Point(63, 115);
            this.foodQuantityLabel.Name = "foodQuantityLabel";
            this.foodQuantityLabel.Size = new System.Drawing.Size(21, 13);
            this.foodQuantityLabel.TabIndex = 6;
            this.foodQuantityLabel.Text = "##";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(17, 115);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(34, 13);
            this.foodLabel.TabIndex = 5;
            this.foodLabel.Text = "Food:";
            // 
            // blueprintsTextBox
            // 
            this.blueprintsTextBox.Location = new System.Drawing.Point(146, 89);
            this.blueprintsTextBox.Multiline = true;
            this.blueprintsTextBox.Name = "blueprintsTextBox";
            this.blueprintsTextBox.ReadOnly = true;
            this.blueprintsTextBox.Size = new System.Drawing.Size(100, 100);
            this.blueprintsTextBox.TabIndex = 7;
            // 
            // blueprintsLabel
            // 
            this.blueprintsLabel.AutoSize = true;
            this.blueprintsLabel.Location = new System.Drawing.Point(146, 70);
            this.blueprintsLabel.Name = "blueprintsLabel";
            this.blueprintsLabel.Size = new System.Drawing.Size(56, 13);
            this.blueprintsLabel.TabIndex = 8;
            this.blueprintsLabel.Text = "Blueprints:";
            // 
            // ColonyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.blueprintsLabel);
            this.Controls.Add(this.blueprintsTextBox);
            this.Controls.Add(this.foodQuantityLabel);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.stoneQuantityLabel);
            this.Controls.Add(this.stoneLabel);
            this.Controls.Add(this.woodQuantityLabel);
            this.Controls.Add(this.woodLabel);
            this.Controls.Add(this.colonyNameLabel);
            this.Name = "ColonyInfoForm";
            this.Text = "ColonyInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColonyInfoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label woodLabel;
        private System.Windows.Forms.Label stoneLabel;
        private System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label woodQuantityLabel;
        public System.Windows.Forms.Label stoneQuantityLabel;
        public System.Windows.Forms.Label foodQuantityLabel;
        public System.Windows.Forms.Label colonyNameLabel;
        private System.Windows.Forms.Label blueprintsLabel;
        public System.Windows.Forms.TextBox blueprintsTextBox;
    }
}