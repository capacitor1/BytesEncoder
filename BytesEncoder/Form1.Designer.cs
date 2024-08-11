namespace BytesEncoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.Compressed = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HCT = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input.Location = new System.Drawing.Point(44, 137);
            this.Input.MaxLength = 2147438647;
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input.Size = new System.Drawing.Size(541, 560);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output.Location = new System.Drawing.Point(698, 135);
            this.Output.MaxLength = 2147438647;
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(539, 560);
            this.Output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("杨任东竹石体-Regular", 18F);
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "兽音译者 C#版";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(653, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "将输入的数据按每2bit分割，使用设定的编码字符进行编码。支持压缩文本以减少编码长度。";
            // 
            // EncC
            // 
            this.EncC.Location = new System.Drawing.Point(100, 14);
            this.EncC.MaxLength = 4;
            this.EncC.Name = "EncC";
            this.EncC.Size = new System.Drawing.Size(100, 25);
            this.EncC.TabIndex = 4;
            this.EncC.Text = "嗷呜喵~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "编码字符：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HCT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Mode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Compressed);
            this.groupBox1.Controls.Add(this.Standard);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EncC);
            this.groupBox1.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.groupBox1.Location = new System.Drawing.Point(45, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制台";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.label4.Location = new System.Drawing.Point(206, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "（限制输入4个字符，不能重复）";
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.Run.Location = new System.Drawing.Point(599, 170);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(88, 29);
            this.Run.TabIndex = 7;
            this.Run.Text = "运行";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Checked = true;
            this.Standard.Location = new System.Drawing.Point(100, 47);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(90, 22);
            this.Standard.TabIndex = 7;
            this.Standard.TabStop = true;
            this.Standard.Text = "标准编码";
            this.Standard.UseVisualStyleBackColor = true;
            // 
            // Compressed
            // 
            this.Compressed.AutoSize = true;
            this.Compressed.Location = new System.Drawing.Point(209, 47);
            this.Compressed.Name = "Compressed";
            this.Compressed.Size = new System.Drawing.Size(90, 22);
            this.Compressed.TabIndex = 8;
            this.Compressed.Text = "压缩编码";
            this.Compressed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "模式选择：";
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Checked = true;
            this.Mode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Mode.Location = new System.Drawing.Point(743, 21);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(219, 22);
            this.Mode.TabIndex = 10;
            this.Mode.Text = "打勾为编码，不打勾为解码";
            this.Mode.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("杨任东竹石体-Regular", 12F);
            this.label6.Location = new System.Drawing.Point(649, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "功能选择：";
            // 
            // HCT
            // 
            this.HCT.AutoSize = true;
            this.HCT.Location = new System.Drawing.Point(743, 45);
            this.HCT.Name = "HCT";
            this.HCT.Size = new System.Drawing.Size(267, 22);
            this.HCT.TabIndex = 12;
            this.HCT.Text = "高级压缩（实验功能，谨慎勾选）";
            this.HCT.UseVisualStyleBackColor = true;
            this.HCT.CheckedChanged += new System.EventHandler(this.HCT_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 717);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "兽音译者 C#版";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.RadioButton Compressed;
        private System.Windows.Forms.RadioButton Standard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Mode;
        private System.Windows.Forms.CheckBox HCT;
    }
}

