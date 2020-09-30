namespace Math_Quiz
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(201, 26);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MathJax_Main", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time left";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(182, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(37, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label3.Location = new System.Drawing.Point(131, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label6.Location = new System.Drawing.Point(297, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "=";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sum.Location = new System.Drawing.Point(353, 128);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(69, 27);
            this.sum.TabIndex = 7;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("庞门正道标题体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(137, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(163, 83);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

