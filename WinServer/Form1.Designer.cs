﻿namespace WinServer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加对象ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加对象ToolStripMenuItem,
            this.添加页面ToolStripMenuItem,
            this.表单ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // 添加对象ToolStripMenuItem
            // 
            this.添加对象ToolStripMenuItem.Name = "添加对象ToolStripMenuItem";
            this.添加对象ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加对象ToolStripMenuItem.Text = "对象";
            // 
            // 添加页面ToolStripMenuItem
            // 
            this.添加页面ToolStripMenuItem.Name = "添加页面ToolStripMenuItem";
            this.添加页面ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加页面ToolStripMenuItem.Text = "页面";
            // 
            // 表单ToolStripMenuItem
            // 
            this.表单ToolStripMenuItem.Name = "表单ToolStripMenuItem";
            this.表单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.表单ToolStripMenuItem.Text = "表单";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加对象ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表单ToolStripMenuItem;
    }
}

