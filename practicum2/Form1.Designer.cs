namespace practicum2
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
            this.button1 = new System.Windows.Forms.Button();
            this.num1lab = new System.Windows.Forms.Label();
            this.num1Text = new System.Windows.Forms.TextBox();
            this.methodOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lambdaOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num2Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num3Text = new System.Windows.Forms.TextBox();
            this.num3TextLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1lab
            // 
            this.num1lab.AutoSize = true;
            this.num1lab.Location = new System.Drawing.Point(29, 23);
            this.num1lab.Name = "num1lab";
            this.num1lab.Size = new System.Drawing.Size(53, 13);
            this.num1lab.TabIndex = 4;
            this.num1lab.Text = "Number 1";
            // 
            // num1Text
            // 
            this.num1Text.Location = new System.Drawing.Point(117, 20);
            this.num1Text.Name = "num1Text";
            this.num1Text.Size = new System.Drawing.Size(27, 20);
            this.num1Text.TabIndex = 5;
            // 
            // methodOutput
            // 
            this.methodOutput.Location = new System.Drawing.Point(32, 136);
            this.methodOutput.Name = "methodOutput";
            this.methodOutput.Size = new System.Drawing.Size(245, 229);
            this.methodOutput.TabIndex = 6;
            this.methodOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Method output";
            // 
            // lambdaOutput
            // 
            this.lambdaOutput.Location = new System.Drawing.Point(311, 136);
            this.lambdaOutput.Name = "lambdaOutput";
            this.lambdaOutput.Size = new System.Drawing.Size(245, 229);
            this.lambdaOutput.TabIndex = 8;
            this.lambdaOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lambda output";
            // 
            // num2Text
            // 
            this.num2Text.Location = new System.Drawing.Point(117, 49);
            this.num2Text.Name = "num2Text";
            this.num2Text.Size = new System.Drawing.Size(27, 20);
            this.num2Text.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number 2";
            // 
            // num3Text
            // 
            this.num3Text.Location = new System.Drawing.Point(117, 78);
            this.num3Text.Name = "num3Text";
            this.num3Text.Size = new System.Drawing.Size(27, 20);
            this.num3Text.TabIndex = 13;
            // 
            // num3TextLb
            // 
            this.num3TextLb.AutoSize = true;
            this.num3TextLb.Location = new System.Drawing.Point(29, 81);
            this.num3TextLb.Name = "num3TextLb";
            this.num3TextLb.Size = new System.Drawing.Size(53, 13);
            this.num3TextLb.TabIndex = 12;
            this.num3TextLb.Text = "Number 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 406);
            this.Controls.Add(this.num3Text);
            this.Controls.Add(this.num3TextLb);
            this.Controls.Add(this.num2Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lambdaOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.methodOutput);
            this.Controls.Add(this.num1Text);
            this.Controls.Add(this.num1lab);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label num1lab;
        private System.Windows.Forms.TextBox num1Text;
        private System.Windows.Forms.RichTextBox methodOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox lambdaOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num2Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num3Text;
        private System.Windows.Forms.Label num3TextLb;
    }
}

