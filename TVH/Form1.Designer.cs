namespace TVH
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
            this.machtButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.milleniaCount = new System.Windows.Forms.Label();
            this.secondCount = new System.Windows.Forms.Label();
            this.minuteCount = new System.Windows.Forms.Label();
            this.dayCount = new System.Windows.Forms.Label();
            this.yearCount = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.forloopButton = new System.Windows.Forms.Button();
            this.recursieButton = new System.Windows.Forms.Button();
            this.hourCount = new System.Windows.Forms.Label();
            this.timeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // machtButton
            // 
            this.machtButton.Location = new System.Drawing.Point(12, 63);
            this.machtButton.Name = "machtButton";
            this.machtButton.Size = new System.Drawing.Size(82, 35);
            this.machtButton.TabIndex = 0;
            this.machtButton.Text = "Macht";
            this.machtButton.UseVisualStyleBackColor = true;
            this.machtButton.Click += new System.EventHandler(this.machtButton_Click_1);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(13, 35);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(257, 22);
            this.inputTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aantal ringen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal Moves";
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.hourCount);
            this.timeBox.Controls.Add(this.milleniaCount);
            this.timeBox.Controls.Add(this.secondCount);
            this.timeBox.Controls.Add(this.minuteCount);
            this.timeBox.Controls.Add(this.dayCount);
            this.timeBox.Controls.Add(this.yearCount);
            this.timeBox.Location = new System.Drawing.Point(13, 155);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(418, 210);
            this.timeBox.TabIndex = 6;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Tijdsduur";
            // 
            // milleniaCount
            // 
            this.milleniaCount.AutoSize = true;
            this.milleniaCount.Location = new System.Drawing.Point(33, 35);
            this.milleniaCount.Name = "milleniaCount";
            this.milleniaCount.Size = new System.Drawing.Size(67, 17);
            this.milleniaCount.TabIndex = 12;
            this.milleniaCount.Text = "Millenia 0";
            // 
            // secondCount
            // 
            this.secondCount.AutoSize = true;
            this.secondCount.Location = new System.Drawing.Point(33, 163);
            this.secondCount.Name = "secondCount";
            this.secondCount.Size = new System.Drawing.Size(84, 17);
            this.secondCount.TabIndex = 11;
            this.secondCount.Text = "Seconden 0";
            // 
            // minuteCount
            // 
            this.minuteCount.AutoSize = true;
            this.minuteCount.Location = new System.Drawing.Point(33, 139);
            this.minuteCount.Name = "minuteCount";
            this.minuteCount.Size = new System.Drawing.Size(70, 17);
            this.minuteCount.TabIndex = 10;
            this.minuteCount.Text = "Minuten 0";
            // 
            // dayCount
            // 
            this.dayCount.AutoSize = true;
            this.dayCount.Location = new System.Drawing.Point(31, 85);
            this.dayCount.Name = "dayCount";
            this.dayCount.Size = new System.Drawing.Size(62, 17);
            this.dayCount.TabIndex = 9;
            this.dayCount.Text = "Dagen 0";
            // 
            // yearCount
            // 
            this.yearCount.AutoSize = true;
            this.yearCount.Location = new System.Drawing.Point(33, 58);
            this.yearCount.Name = "yearCount";
            this.yearCount.Size = new System.Drawing.Size(56, 17);
            this.yearCount.TabIndex = 8;
            this.yearCount.Text = "Jaren 0";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(340, 38);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(16, 17);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "0";
            // 
            // forloopButton
            // 
            this.forloopButton.Location = new System.Drawing.Point(100, 63);
            this.forloopButton.Name = "forloopButton";
            this.forloopButton.Size = new System.Drawing.Size(82, 35);
            this.forloopButton.TabIndex = 8;
            this.forloopButton.Text = "For-Loop";
            this.forloopButton.UseVisualStyleBackColor = true;
            this.forloopButton.Click += new System.EventHandler(this.forloopButton_Click);
            // 
            // recursieButton
            // 
            this.recursieButton.Location = new System.Drawing.Point(188, 63);
            this.recursieButton.Name = "recursieButton";
            this.recursieButton.Size = new System.Drawing.Size(82, 35);
            this.recursieButton.TabIndex = 9;
            this.recursieButton.Text = "Recursie";
            this.recursieButton.UseVisualStyleBackColor = true;
            // 
            // hourCount
            // 
            this.hourCount.AutoSize = true;
            this.hourCount.Location = new System.Drawing.Point(31, 112);
            this.hourCount.Name = "hourCount";
            this.hourCount.Size = new System.Drawing.Size(51, 17);
            this.hourCount.TabIndex = 13;
            this.hourCount.Text = "Uren 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 385);
            this.Controls.Add(this.recursieButton);
            this.Controls.Add(this.forloopButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.machtButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button machtButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.Label milleniaCount;
        private System.Windows.Forms.Label secondCount;
        private System.Windows.Forms.Label minuteCount;
        private System.Windows.Forms.Label dayCount;
        private System.Windows.Forms.Label yearCount;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button forloopButton;
        private System.Windows.Forms.Button recursieButton;
        private System.Windows.Forms.Label hourCount;
    }
}

