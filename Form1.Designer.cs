namespace WindowsFormsApp_001
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
            System.Windows.Forms.Button btn;
            this.btn_M = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new System.Drawing.Point(24, 186);
            btn.Name = "btn";
            btn.Size = new System.Drawing.Size(150, 59);
            btn.TabIndex = 0;
            btn.Text = "Change background";
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_M
            // 
            this.btn_M.Location = new System.Drawing.Point(227, 192);
            this.btn_M.Name = "btn_M";
            this.btn_M.Size = new System.Drawing.Size(165, 52);
            this.btn_M.TabIndex = 1;
            this.btn_M.Text = "Message";
            this.btn_M.UseVisualStyleBackColor = true;
            this.btn_M.Click += new System.EventHandler(this.btn_M_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Background";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(336, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 64);
            this.button4.TabIndex = 6;
            this.button4.Text = "Open Form2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_M);
            this.Controls.Add(btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

