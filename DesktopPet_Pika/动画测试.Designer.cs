
namespace DesktopPet_Pika
{
    partial class 动画测试
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(动画测试));
            this.tmrDrag = new System.Windows.Forms.Timer(this.components);
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.眨眼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.衣柜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圣诞帽子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.樱花帽子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水手帽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.风车帽子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圣诞衣服ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.和服ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDrag
            // 
            this.tmrDrag.Tick += new System.EventHandler(this.tmrDrag_Tick);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.眨眼ToolStripMenuItem,
            this.衣柜ToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(109, 76);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 眨眼ToolStripMenuItem
            // 
            this.眨眼ToolStripMenuItem.Name = "眨眼ToolStripMenuItem";
            this.眨眼ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.眨眼ToolStripMenuItem.Text = "眨眼";
            this.眨眼ToolStripMenuItem.Click += new System.EventHandler(this.眨眼ToolStripMenuItem_Click);
            // 
            // 衣柜ToolStripMenuItem
            // 
            this.衣柜ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.圣诞帽子ToolStripMenuItem,
            this.樱花帽子ToolStripMenuItem,
            this.水手帽ToolStripMenuItem,
            this.风车帽子ToolStripMenuItem,
            this.圣诞衣服ToolStripMenuItem,
            this.和服ToolStripMenuItem});
            this.衣柜ToolStripMenuItem.Name = "衣柜ToolStripMenuItem";
            this.衣柜ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.衣柜ToolStripMenuItem.Text = "衣柜";
            // 
            // 圣诞帽子ToolStripMenuItem
            // 
            this.圣诞帽子ToolStripMenuItem.Name = "圣诞帽子ToolStripMenuItem";
            this.圣诞帽子ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.圣诞帽子ToolStripMenuItem.Text = "帽子 — 圣诞";
            this.圣诞帽子ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 樱花帽子ToolStripMenuItem
            // 
            this.樱花帽子ToolStripMenuItem.Name = "樱花帽子ToolStripMenuItem";
            this.樱花帽子ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.樱花帽子ToolStripMenuItem.Text = "帽子 — 樱花";
            this.樱花帽子ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 水手帽ToolStripMenuItem
            // 
            this.水手帽ToolStripMenuItem.Name = "水手帽ToolStripMenuItem";
            this.水手帽ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.水手帽ToolStripMenuItem.Text = "帽子 — 水手帽";
            this.水手帽ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 风车帽子ToolStripMenuItem
            // 
            this.风车帽子ToolStripMenuItem.Name = "风车帽子ToolStripMenuItem";
            this.风车帽子ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.风车帽子ToolStripMenuItem.Text = "帽子 — 风车";
            this.风车帽子ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 圣诞衣服ToolStripMenuItem
            // 
            this.圣诞衣服ToolStripMenuItem.Name = "圣诞衣服ToolStripMenuItem";
            this.圣诞衣服ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.圣诞衣服ToolStripMenuItem.Text = "衣服 — 圣诞";
            this.圣诞衣服ToolStripMenuItem.Click += new System.EventHandler(this.衣服ToolStripMenuItem_Click);
            // 
            // 和服ToolStripMenuItem
            // 
            this.和服ToolStripMenuItem.Name = "和服ToolStripMenuItem";
            this.和服ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.和服ToolStripMenuItem.Text = "衣服 — 和服";
            this.和服ToolStripMenuItem.Click += new System.EventHandler(this.衣服ToolStripMenuItem_Click);
            // 
            // tmrBlink
            // 
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.rightClickMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // 动画测试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 303);
            this.ContextMenuStrip = this.rightClickMenu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "动画测试";
            this.Text = "动画测试";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.动画测试_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.动画测试_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.动画测试_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.动画测试_MouseUp);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrDrag;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 眨眼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 衣柜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圣诞帽子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 樱花帽子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水手帽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 风车帽子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圣诞衣服ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 和服ToolStripMenuItem;
    }
}