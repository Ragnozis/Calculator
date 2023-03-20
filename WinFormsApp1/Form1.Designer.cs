namespace WinFormsApp1
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
            this.Screen = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Еquals = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Enabled = false;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Screen.Location = new System.Drawing.Point(12, 44);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(402, 43);
            this.Screen.TabIndex = 0;
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(26, 152);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(74, 36);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(132, 152);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(74, 36);
            this.Backspace.TabIndex = 2;
            this.Backspace.Text = "<=";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Sign
            // 
            this.Sign.Location = new System.Drawing.Point(235, 152);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(74, 36);
            this.Sign.TabIndex = 3;
            this.Sign.Text = "+/-";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(340, 152);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(74, 36);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(26, 240);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(74, 36);
            this.Seven.TabIndex = 5;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(132, 240);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(74, 36);
            this.Eight.TabIndex = 6;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(235, 240);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(74, 36);
            this.Nine.TabIndex = 7;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(340, 240);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(74, 36);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(26, 331);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(74, 36);
            this.Four.TabIndex = 9;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(132, 331);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(74, 36);
            this.Five.TabIndex = 10;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(235, 331);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(74, 36);
            this.Six.TabIndex = 11;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(340, 331);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(74, 36);
            this.Multiplication.TabIndex = 12;
            this.Multiplication.Text = "X";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(26, 415);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(74, 36);
            this.One.TabIndex = 13;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(132, 415);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(74, 36);
            this.Two.TabIndex = 14;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(235, 415);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(74, 36);
            this.Three.TabIndex = 15;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(340, 415);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(74, 36);
            this.Division.TabIndex = 16;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(26, 503);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(74, 36);
            this.Zero.TabIndex = 17;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(132, 503);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(74, 36);
            this.Dot.TabIndex = 18;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Еquals
            // 
            this.Еquals.Location = new System.Drawing.Point(235, 503);
            this.Еquals.Name = "Еquals";
            this.Еquals.Size = new System.Drawing.Size(179, 36);
            this.Еquals.TabIndex = 19;
            this.Еquals.Text = "=";
            this.Еquals.UseVisualStyleBackColor = true;
            this.Еquals.Click += new System.EventHandler(this.Еquals_Click);
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.BackColor = System.Drawing.SystemColors.Control;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(13, 51);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(87, 30);
            this.Label.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 567);
            this.Controls.Add(this.Еquals);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Screen;
        private Button Clear;
        private Button Backspace;
        private Button Sign;
        private Button Plus;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Minus;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Multiplication;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Division;
        private Button Zero;
        private Button Dot;
        private Button Еquals;
        private Label Label;
    }
}