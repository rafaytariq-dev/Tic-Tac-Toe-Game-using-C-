﻿namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 78);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0,0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button1.Click += new System.EventHandler(this.buttonclick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 78);
            this.button2.TabIndex = 2;
            this.button2.Tag = "1,0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button2.Click += new System.EventHandler(this.buttonclick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 78);
            this.button3.TabIndex = 3;
            this.button3.Tag = "2,0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button3.Click += new System.EventHandler(this.buttonclick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 78);
            this.button4.TabIndex = 4;
            this.button4.Tag = "0,1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button4.Click += new System.EventHandler(this.buttonclick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 78);
            this.button5.TabIndex = 5;
            this.button5.Tag = "1,1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button5.Click += new System.EventHandler(this.buttonclick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 78);
            this.button6.TabIndex = 6;
            this.button6.Tag = "2,1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button6.Click += new System.EventHandler(this.buttonclick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(247, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 78);
            this.button7.TabIndex = 7;
            this.button7.Tag = "0,2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button7.Click += new System.EventHandler(this.buttonclick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(247, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 78);
            this.button8.TabIndex = 8;
            this.button8.Tag = "1,2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button8.Click += new System.EventHandler(this.buttonclick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(247, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 78);
            this.button9.TabIndex = 9;
            this.button9.Tag = "2,2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.ContextMenuStripChanged += new System.EventHandler(this.button9_ContextMenuStripChanged);
            this.button9.Click += new System.EventHandler(this.buttonclick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(472, 305);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 37);
            this.button10.TabIndex = 11;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Score Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

