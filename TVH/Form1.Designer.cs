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
            this.goButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.newInput = new System.Windows.Forms.Button();
            this.yearCount = new System.Windows.Forms.Label();
            this.dayCount = new System.Windows.Forms.Label();
            this.minuteCount = new System.Windows.Forms.Label();
            this.secondCount = new System.Windows.Forms.Label();
            this.mileniaCount = new System.Windows.Forms.Label();
            this.timeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(180, 79);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(82, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aantal ringen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal Moves";
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.mileniaCount);
            this.timeBox.Controls.Add(this.secondCount);
            this.timeBox.Controls.Add(this.minuteCount);
            this.timeBox.Controls.Add(this.dayCount);
            this.timeBox.Controls.Add(this.yearCount);
            this.timeBox.Location = new System.Drawing.Point(12, 318);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(418, 210);
            this.timeBox.TabIndex = 6;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Tijdsduur";
            // 
            // newInput
            // 
            this.newInput.Location = new System.Drawing.Point(12, 12);
            this.newInput.Name = "newInput";
            this.newInput.Size = new System.Drawing.Size(49, 26);
            this.newInput.TabIndex = 7;
            this.newInput.Text = "Nieuw";
            this.newInput.UseVisualStyleBackColor = true;
            // 
            // yearCount
            // 
            this.yearCount.AutoSize = true;
            this.yearCount.Location = new System.Drawing.Point(33, 71);
            this.yearCount.Name = "yearCount";
            this.yearCount.Size = new System.Drawing.Size(64, 17);
            this.yearCount.TabIndex = 8;
            this.yearCount.Text = "0 Jaaren";
            // 
            // dayCount
            // 
            this.dayCount.AutoSize = true;
            this.dayCount.Location = new System.Drawing.Point(33, 108);
            this.dayCount.Name = "dayCount";
            this.dayCount.Size = new System.Drawing.Size(62, 17);
            this.dayCount.TabIndex = 9;
            this.dayCount.Text = "0 Dagen";
            // 
            // minuteCount
            // 
            this.minuteCount.AutoSize = true;
            this.minuteCount.Location = new System.Drawing.Point(33, 139);
            this.minuteCount.Name = "minuteCount";
            this.minuteCount.Size = new System.Drawing.Size(70, 17);
            this.minuteCount.TabIndex = 10;
            this.minuteCount.Text = "0 Minuten";
            // 
            // secondCount
            // 
            this.secondCount.AutoSize = true;
            this.secondCount.Location = new System.Drawing.Point(33, 169);
            this.secondCount.Name = "secondCount";
            this.secondCount.Size = new System.Drawing.Size(84, 17);
            this.secondCount.TabIndex = 11;
            this.secondCount.Text = "0 Seconden";
            // 
            // mileniaCount
            // 
            this.mileniaCount.AutoSize = true;
            this.mileniaCount.Location = new System.Drawing.Point(33, 36);
            this.mileniaCount.Name = "mileniaCount";
            this.mileniaCount.Size = new System.Drawing.Size(64, 17);
            this.mileniaCount.TabIndex = 12;
            this.mileniaCount.Text = "0 Milenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 540);
            this.Controls.Add(this.newInput);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.Label mileniaCount;
        private System.Windows.Forms.Label secondCount;
        private System.Windows.Forms.Label minuteCount;
        private System.Windows.Forms.Label dayCount;
        private System.Windows.Forms.Label yearCount;
        private System.Windows.Forms.Button newInput;
    }
}

