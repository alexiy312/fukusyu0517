namespace fukusyu0517
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.up_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reset_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "(\'ω\')";
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(448, 235);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(60, 20);
            this.up_button.TabIndex = 1;
            this.up_button.Text = "↑";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(400, 261);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(60, 20);
            this.left_button.TabIndex = 2;
            this.left_button.Text = "←";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(495, 261);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(60, 20);
            this.right_button.TabIndex = 3;
            this.right_button.Text = "→";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(448, 287);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(60, 20);
            this.down_button.TabIndex = 4;
            this.down_button.Text = "↓";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(449, 324);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(58, 18);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "演習７－１";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "演習７－２";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "演習７－４";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

