
namespace TIP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.N1 = new System.Windows.Forms.NumericUpDown();
            this.N2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No . of person";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(241, 50);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(100, 22);
            this.T1.TabIndex = 3;
            this.T1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(241, 136);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(120, 22);
            this.N1.TabIndex = 5;
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(241, 203);
            this.N2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(120, 22);
            this.N2.TabIndex = 6;
            this.N2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip bill per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total tip per person";
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(609, 54);
            this.T2.Name = "T2";
            this.T2.ReadOnly = true;
            this.T2.Size = new System.Drawing.Size(100, 22);
            this.T2.TabIndex = 9;
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(609, 155);
            this.T3.Name = "T3";
            this.T3.ReadOnly = true;
            this.T3.Size = new System.Drawing.Size(100, 22);
            this.T3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.N1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown N1;
        private System.Windows.Forms.NumericUpDown N2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

