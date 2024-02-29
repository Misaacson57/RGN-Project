namespace Project_1
{
    partial class SummaryForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            positiveCountLabel = new Label();
            zeroCountLabel = new Label();
            negativeCountLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 63);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "15 numbers selected:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(74, 110);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 196);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Positives:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 263);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Total Zero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 346);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 4;
            label5.Text = "Total Negatives";
            // 
            // positiveCountLabel
            // 
            positiveCountLabel.AutoSize = true;
            positiveCountLabel.Location = new Point(292, 196);
            positiveCountLabel.Name = "positiveCountLabel";
            positiveCountLabel.Size = new Size(15, 20);
            positiveCountLabel.TabIndex = 5;
            positiveCountLabel.Text = "-";
            // 
            // zeroCountLabel
            // 
            zeroCountLabel.AutoSize = true;
            zeroCountLabel.Location = new Point(292, 263);
            zeroCountLabel.Name = "zeroCountLabel";
            zeroCountLabel.Size = new Size(15, 20);
            zeroCountLabel.TabIndex = 6;
            zeroCountLabel.Text = "-";
            // 
            // negativeCountLabel
            // 
            negativeCountLabel.AutoSize = true;
            negativeCountLabel.Location = new Point(292, 346);
            negativeCountLabel.Name = "negativeCountLabel";
            negativeCountLabel.Size = new Size(15, 20);
            negativeCountLabel.TabIndex = 7;
            negativeCountLabel.Text = "-";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(negativeCountLabel);
            Controls.Add(zeroCountLabel);
            Controls.Add(positiveCountLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SummaryForm";
            Text = "Summary Form";
            Load += SummaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label positiveCountLabel;
        private Label zeroCountLabel;
        private Label negativeCountLabel;
    }
}