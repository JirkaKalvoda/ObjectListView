
namespace TestProject1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_remove = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.l_index = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_indices = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.l_indices);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.l_index);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_remove);
            this.panel1.Controls.Add(this.b_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 85);
            this.panel1.TabIndex = 0;
            // 
            // b_remove
            // 
            this.b_remove.Location = new System.Drawing.Point(142, 46);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(81, 33);
            this.b_remove.TabIndex = 1;
            this.b_remove.Text = "remove";
            this.b_remove.UseVisualStyleBackColor = true;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(30, 46);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(81, 33);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "add";
            this.b_add.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 196);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "SelectedIndex =";
            // 
            // l_index
            // 
            this.l_index.AutoSize = true;
            this.l_index.Location = new System.Drawing.Point(129, 22);
            this.l_index.Name = "l_index";
            this.l_index.Size = new System.Drawing.Size(11, 12);
            this.l_index.TabIndex = 3;
            this.l_index.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "SelectedInices =";
            // 
            // l_indices
            // 
            this.l_indices.AutoSize = true;
            this.l_indices.Location = new System.Drawing.Point(262, 22);
            this.l_indices.Name = "l_indices";
            this.l_indices.Size = new System.Drawing.Size(11, 12);
            this.l_indices.TabIndex = 5;
            this.l_indices.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 281);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_indices;
        private System.Windows.Forms.Label label2;
    }
}

