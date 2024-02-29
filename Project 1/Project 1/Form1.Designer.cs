namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            numberRangeTextBox = new TextBox();
            enterButton = new Button();
            slowRadioButton = new RadioButton();
            fastRadioButton = new RadioButton();
            randomNumberLabel = new Label();
            label2 = new Label();
            selectedNumbersLabel = new Label();
            numberGeneratorTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 70);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a number to set a range:";
            // 
            // numberRangeTextBox
            // 
            numberRangeTextBox.Location = new Point(287, 67);
            numberRangeTextBox.Name = "numberRangeTextBox";
            numberRangeTextBox.Size = new Size(125, 27);
            numberRangeTextBox.TabIndex = 1;
            numberRangeTextBox.TextChanged += numberRangeTextBox_TextChanged;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(471, 70);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(94, 29);
            enterButton.TabIndex = 2;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // slowRadioButton
            // 
            slowRadioButton.AutoSize = true;
            slowRadioButton.Checked = true;
            slowRadioButton.Location = new Point(492, 197);
            slowRadioButton.Name = "slowRadioButton";
            slowRadioButton.Size = new Size(62, 24);
            slowRadioButton.TabIndex = 3;
            slowRadioButton.TabStop = true;
            slowRadioButton.Text = "Slow";
            slowRadioButton.UseVisualStyleBackColor = true;
            slowRadioButton.CheckedChanged += slowRadioButton_CheckedChanged;
            // 
            // fastRadioButton
            // 
            fastRadioButton.AutoSize = true;
            fastRadioButton.Location = new Point(492, 227);
            fastRadioButton.Name = "fastRadioButton";
            fastRadioButton.Size = new Size(55, 24);
            fastRadioButton.TabIndex = 4;
            fastRadioButton.Text = "Fast";
            fastRadioButton.UseVisualStyleBackColor = true;
            fastRadioButton.CheckedChanged += fastRadioButton_CheckedChanged;
            // 
            // randomNumberLabel
            // 
            randomNumberLabel.AutoSize = true;
            randomNumberLabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            randomNumberLabel.ForeColor = Color.Green;
            randomNumberLabel.Location = new Point(110, 159);
            randomNumberLabel.Name = "randomNumberLabel";
            randomNumberLabel.Size = new Size(80, 106);
            randomNumberLabel.TabIndex = 5;
            randomNumberLabel.Text = "?";
            randomNumberLabel.Click += randomNumberLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 299);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 6;
            label2.Text = "15 numbers selected:";
            // 
            // selectedNumbersLabel
            // 
            selectedNumbersLabel.AutoSize = true;
            selectedNumbersLabel.ForeColor = Color.Fuchsia;
            selectedNumbersLabel.Location = new Point(64, 371);
            selectedNumbersLabel.Name = "selectedNumbersLabel";
            selectedNumbersLabel.Size = new Size(0, 20);
            selectedNumbersLabel.TabIndex = 7;
            // 
            // numberGeneratorTimer
            // 
            numberGeneratorTimer.Tick += numberGeneratorTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectedNumbersLabel);
            Controls.Add(label2);
            Controls.Add(randomNumberLabel);
            Controls.Add(fastRadioButton);
            Controls.Add(slowRadioButton);
            Controls.Add(enterButton);
            Controls.Add(numberRangeTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Main Form";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numberRangeTextBox;
        private Button enterButton;
        private RadioButton slowRadioButton;
        private RadioButton fastRadioButton;
        private Label randomNumberLabel;
        private Label label2;
        private Label selectedNumbersLabel;
        private System.Windows.Forms.Timer numberGeneratorTimer;
    }
}
