namespace XML2CSV
{
    partial class XML2CSV
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
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Convert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_LoadFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Load
            // 
            this.BTN_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_Load.Location = new System.Drawing.Point(39, 84);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(88, 69);
            this.BTN_Load.TabIndex = 0;
            this.BTN_Load.Tag = "BTN_Load";
            this.BTN_Load.Text = "Load XML";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Convert
            // 
            this.BTN_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_Convert.Location = new System.Drawing.Point(39, 168);
            this.BTN_Convert.Name = "BTN_Convert";
            this.BTN_Convert.Size = new System.Drawing.Size(195, 59);
            this.BTN_Convert.TabIndex = 1;
            this.BTN_Convert.Text = "Convert";
            this.BTN_Convert.UseVisualStyleBackColor = true;
            this.BTN_Convert.Click += new System.EventHandler(this.BTN_Convert_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(119, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_Info_Click);
            // 
            // button2
            // 
            this.BTN_LoadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_LoadFiles.Location = new System.Drawing.Point(151, 84);
            this.BTN_LoadFiles.Name = "button2";
            this.BTN_LoadFiles.Size = new System.Drawing.Size(83, 69);
            this.BTN_LoadFiles.TabIndex = 3;
            this.BTN_LoadFiles.Tag = "BTN_LoadFiles";
            this.BTN_LoadFiles.Text = "Load XML Files";
            this.BTN_LoadFiles.UseVisualStyleBackColor = true;
            this.BTN_LoadFiles.Click += new System.EventHandler(this.BTN_LoadFiles_Click);
            // 
            // XML2CSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.BTN_LoadFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Convert);
            this.Controls.Add(this.BTN_Load);
            this.Name = "XML2CSV";
            this.Text = "XML2CSV";
            this.Load += new System.EventHandler(this.XML2CSV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.Button BTN_Convert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_LoadFiles;
    }
}

