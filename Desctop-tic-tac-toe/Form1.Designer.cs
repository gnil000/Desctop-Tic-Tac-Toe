using System.ComponentModel;

namespace Desctop_tic_tac_toe
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
            this.button1_1 = new System.Windows.Forms.Button();
            this.button1_2 = new System.Windows.Forms.Button();
            this.button1_3 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button2_3 = new System.Windows.Forms.Button();
            this.button3_1 = new System.Windows.Forms.Button();
            this.button3_2 = new System.Windows.Forms.Button();
            this.button3_3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_1
            // 
            this.button1_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_1.ForeColor = System.Drawing.Color.White;
            this.button1_1.Location = new System.Drawing.Point(93, 81);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(60, 60);
            this.button1_1.TabIndex = 0;
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button1_2
            // 
            this.button1_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_2.ForeColor = System.Drawing.Color.White;
            this.button1_2.Location = new System.Drawing.Point(159, 81);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(60, 60);
            this.button1_2.TabIndex = 1;
            this.button1_2.UseVisualStyleBackColor = true;
            this.button1_2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button1_3
            // 
            this.button1_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_3.ForeColor = System.Drawing.Color.White;
            this.button1_3.Location = new System.Drawing.Point(225, 81);
            this.button1_3.Name = "button1_3";
            this.button1_3.Size = new System.Drawing.Size(60, 60);
            this.button1_3.TabIndex = 2;
            this.button1_3.UseVisualStyleBackColor = true;
            this.button1_3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2_1
            // 
            this.button2_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_1.ForeColor = System.Drawing.Color.White;
            this.button2_1.Location = new System.Drawing.Point(93, 147);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(60, 60);
            this.button2_1.TabIndex = 3;
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2_2
            // 
            this.button2_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_2.ForeColor = System.Drawing.Color.White;
            this.button2_2.Location = new System.Drawing.Point(159, 147);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(60, 60);
            this.button2_2.TabIndex = 4;
            this.button2_2.UseVisualStyleBackColor = true;
            this.button2_2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2_3
            // 
            this.button2_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_3.ForeColor = System.Drawing.Color.White;
            this.button2_3.Location = new System.Drawing.Point(225, 147);
            this.button2_3.Name = "button2_3";
            this.button2_3.Size = new System.Drawing.Size(60, 60);
            this.button2_3.TabIndex = 5;
            this.button2_3.UseVisualStyleBackColor = true;
            this.button2_3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button3_1
            // 
            this.button3_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_1.ForeColor = System.Drawing.Color.White;
            this.button3_1.Location = new System.Drawing.Point(93, 213);
            this.button3_1.Name = "button3_1";
            this.button3_1.Size = new System.Drawing.Size(60, 60);
            this.button3_1.TabIndex = 6;
            this.button3_1.UseVisualStyleBackColor = true;
            this.button3_1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button3_2
            // 
            this.button3_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_2.ForeColor = System.Drawing.Color.White;
            this.button3_2.Location = new System.Drawing.Point(159, 213);
            this.button3_2.Name = "button3_2";
            this.button3_2.Size = new System.Drawing.Size(60, 60);
            this.button3_2.TabIndex = 7;
            this.button3_2.UseVisualStyleBackColor = true;
            this.button3_2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button3_3
            // 
            this.button3_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_3.ForeColor = System.Drawing.Color.White;
            this.button3_3.Location = new System.Drawing.Point(225, 213);
            this.button3_3.Name = "button3_3";
            this.button3_3.Size = new System.Drawing.Size(60, 60);
            this.button3_3.TabIndex = 8;
            this.button3_3.UseVisualStyleBackColor = true;
            this.button3_3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWorkAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 34);
            this.label1.MinimumSize = new System.Drawing.Size(120, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "буп";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3_3);
            this.Controls.Add(this.button3_2);
            this.Controls.Add(this.button3_1);
            this.Controls.Add(this.button2_3);
            this.Controls.Add(this.button2_2);
            this.Controls.Add(this.button2_1);
            this.Controls.Add(this.button1_3);
            this.Controls.Add(this.button1_2);
            this.Controls.Add(this.button1_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_1;
        private Button button1_2;
        private Button button1_3;
        private Button button2_1;
        private Button button2_2;
        private Button button2_3;
        private Button button3_1;
        private Button button3_2;
        private Button button3_3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
    }
}