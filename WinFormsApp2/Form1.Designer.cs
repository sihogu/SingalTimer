namespace WinFormsApp2
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
            button1 = new Button();
            TimeBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            InputTime1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 238);
            button1.Name = "button1";
            button1.Size = new Size(43, 39);
            button1.TabIndex = 0;
            button1.Text = "▶";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TimeBox1
            // 
            TimeBox1.Location = new Point(23, 89);
            TimeBox1.Multiline = true;
            TimeBox1.Name = "TimeBox1";
            TimeBox1.Size = new Size(274, 96);
            TimeBox1.TabIndex = 1;
            TimeBox1.TextChanged += TimeBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // InputTime1
            // 
            InputTime1.Location = new Point(95, 205);
            InputTime1.Name = "InputTime1";
            InputTime1.Size = new Size(43, 27);
            InputTime1.TabIndex = 2;
            InputTime1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 208);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "분";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(label1);
            Controls.Add(InputTime1);
            Controls.Add(TimeBox1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TimeBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox InputTime1;
        private Label label1;
    }
}