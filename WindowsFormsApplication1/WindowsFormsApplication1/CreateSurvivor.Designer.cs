namespace WindowsFormsApplication1
{
    partial class CreateSurvivorForm
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
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.charismaDropDown = new System.Windows.Forms.ComboBox();
            this.fitnessDropDown = new System.Windows.Forms.ComboBox();
            this.fitnessLabel = new System.Windows.Forms.Label();
            this.intelligenceDropDown = new System.Windows.Forms.ComboBox();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.occupationDropDown = new System.Windows.Forms.ComboBox();
            this.occupationLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Location = new System.Drawing.Point(40, 30);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(75, 23);
            this.randomizeBtn.TabIndex = 0;
            this.randomizeBtn.Text = "Randomize";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(84, 77);
            this.nameTextBox.MaxLength = 18;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(43, 121);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(28, 13);
            this.sexLabel.TabIndex = 3;
            this.sexLabel.Text = "Sex:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(43, 174);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age:";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(43, 221);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(34, 13);
            this.statsLabel.TabIndex = 7;
            this.statsLabel.Text = "Stats:";
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Location = new System.Drawing.Point(109, 221);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(53, 13);
            this.charismaLabel.TabIndex = 8;
            this.charismaLabel.Text = "Charisma:";
            // 
            // charismaDropDown
            // 
            this.charismaDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.charismaDropDown.FormattingEnabled = true;
            this.charismaDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.charismaDropDown.Location = new System.Drawing.Point(182, 218);
            this.charismaDropDown.Name = "charismaDropDown";
            this.charismaDropDown.Size = new System.Drawing.Size(121, 21);
            this.charismaDropDown.TabIndex = 9;
            this.charismaDropDown.SelectedIndexChanged += new System.EventHandler(this.charismaDropDown_SelectedIndexChanged);
            // 
            // fitnessDropDown
            // 
            this.fitnessDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fitnessDropDown.FormattingEnabled = true;
            this.fitnessDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.fitnessDropDown.Location = new System.Drawing.Point(182, 261);
            this.fitnessDropDown.Name = "fitnessDropDown";
            this.fitnessDropDown.Size = new System.Drawing.Size(121, 21);
            this.fitnessDropDown.TabIndex = 11;
            this.fitnessDropDown.SelectedIndexChanged += new System.EventHandler(this.fitnessDropDown_SelectedIndexChanged);
            // 
            // fitnessLabel
            // 
            this.fitnessLabel.AutoSize = true;
            this.fitnessLabel.Location = new System.Drawing.Point(109, 264);
            this.fitnessLabel.Name = "fitnessLabel";
            this.fitnessLabel.Size = new System.Drawing.Size(43, 13);
            this.fitnessLabel.TabIndex = 10;
            this.fitnessLabel.Text = "Fitness:";
            // 
            // intelligenceDropDown
            // 
            this.intelligenceDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intelligenceDropDown.FormattingEnabled = true;
            this.intelligenceDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.intelligenceDropDown.Location = new System.Drawing.Point(182, 303);
            this.intelligenceDropDown.Name = "intelligenceDropDown";
            this.intelligenceDropDown.Size = new System.Drawing.Size(121, 21);
            this.intelligenceDropDown.TabIndex = 13;
            this.intelligenceDropDown.SelectedIndexChanged += new System.EventHandler(this.intelligenceDropDown_SelectedIndexChanged);
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(109, 306);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(64, 13);
            this.intelligenceLabel.TabIndex = 12;
            this.intelligenceLabel.Text = "Intelligence:";
            // 
            // occupationDropDown
            // 
            this.occupationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occupationDropDown.FormattingEnabled = true;
            this.occupationDropDown.Items.AddRange(new object[] {
            "Engineer",
            "Doctor",
            "Lawyer"});
            this.occupationDropDown.Location = new System.Drawing.Point(114, 345);
            this.occupationDropDown.Name = "occupationDropDown";
            this.occupationDropDown.Size = new System.Drawing.Size(121, 21);
            this.occupationDropDown.TabIndex = 15;
            this.occupationDropDown.SelectedIndexChanged += new System.EventHandler(this.occupationDropDown_SelectedIndexChanged);
            // 
            // occupationLabel
            // 
            this.occupationLabel.AutoSize = true;
            this.occupationLabel.Location = new System.Drawing.Point(43, 348);
            this.occupationLabel.Name = "occupationLabel";
            this.occupationLabel.Size = new System.Drawing.Size(65, 13);
            this.occupationLabel.TabIndex = 14;
            this.occupationLabel.Text = "Occupation:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(33, 398);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(131, 398);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(84, 121);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 18;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(84, 138);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 19;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(84, 172);
            this.ageNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ageNumeric.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(42, 20);
            this.ageNumeric.TabIndex = 20;
            this.ageNumeric.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumeric.ValueChanged += new System.EventHandler(this.ageNumeric_ValueChanged);
            // 
            // CreateSurvivorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 444);
            this.Controls.Add(this.ageNumeric);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.occupationDropDown);
            this.Controls.Add(this.occupationLabel);
            this.Controls.Add(this.intelligenceDropDown);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.fitnessDropDown);
            this.Controls.Add(this.fitnessLabel);
            this.Controls.Add(this.charismaDropDown);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.randomizeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateSurvivorForm";
            this.Text = "Create a Survivor";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.ComboBox charismaDropDown;
        private System.Windows.Forms.ComboBox fitnessDropDown;
        private System.Windows.Forms.Label fitnessLabel;
        private System.Windows.Forms.ComboBox intelligenceDropDown;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.ComboBox occupationDropDown;
        private System.Windows.Forms.Label occupationLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.NumericUpDown ageNumeric;
    }
}