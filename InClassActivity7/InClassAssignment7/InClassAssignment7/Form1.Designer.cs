namespace InClassAssignment7
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
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectionBox
            // 
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.Items.AddRange(new object[] {
            " TwoIntSum",
            " FiveDoublesGetAverage",
            " TwoRandomInts",
            " TripleDivisibleByThree",
            " ShorterOfTwoStrings",
            " BiggestInDoubleArray",
            " GenerateFiftyNumbers",
            " SameBool",
            " IntTimesDouble",
            " AverageOfMultiDimensionalInt"});
            this.SelectionBox.Location = new System.Drawing.Point(569, 129);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(400, 33);
            this.SelectionBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 673);
            this.Controls.Add(this.SelectionBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectionBox;
    }
}

