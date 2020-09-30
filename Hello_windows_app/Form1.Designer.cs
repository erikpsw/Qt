namespace Hello_windows_app
{
    partial class Btn
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblhello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "click this";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Font = new System.Drawing.Font("Consolas", 20F);
            this.lblhello.Location = new System.Drawing.Point(571, 338);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(0, 40);
            this.lblhello.TabIndex = 1;
            this.lblhello.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 508);
            this.Controls.Add(this.lblhello);
            this.Controls.Add(this.button1);
            this.Name = "Btn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhello;
    }
}

