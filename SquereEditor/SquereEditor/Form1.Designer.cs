namespace SquereEditor
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前をつけて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.画像で出力するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMP形式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNG形式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEG形式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.元に戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.座標へ移動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二点間の距離を測定するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.ツールToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.保存するToolStripMenuItem,
            this.toolStripMenuItem1,
            this.画像で出力するToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.新規作成ToolStripMenuItem.Text = "新規作成";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // 保存するToolStripMenuItem
            // 
            this.保存するToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上書き保存ToolStripMenuItem,
            this.名前をつけて保存ToolStripMenuItem});
            this.保存するToolStripMenuItem.Name = "保存するToolStripMenuItem";
            this.保存するToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.保存するToolStripMenuItem.Text = "保存する";
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存";
            // 
            // 名前をつけて保存ToolStripMenuItem
            // 
            this.名前をつけて保存ToolStripMenuItem.Name = "名前をつけて保存ToolStripMenuItem";
            this.名前をつけて保存ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.名前をつけて保存ToolStripMenuItem.Text = "名前をつけて保存";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // 画像で出力するToolStripMenuItem
            // 
            this.画像で出力するToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMP形式ToolStripMenuItem,
            this.pNG形式ToolStripMenuItem,
            this.jPEG形式ToolStripMenuItem});
            this.画像で出力するToolStripMenuItem.Name = "画像で出力するToolStripMenuItem";
            this.画像で出力するToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.画像で出力するToolStripMenuItem.Text = "画像で出力する";
            // 
            // bMP形式ToolStripMenuItem
            // 
            this.bMP形式ToolStripMenuItem.Name = "bMP形式ToolStripMenuItem";
            this.bMP形式ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bMP形式ToolStripMenuItem.Text = "BMP形式";
            // 
            // pNG形式ToolStripMenuItem
            // 
            this.pNG形式ToolStripMenuItem.Name = "pNG形式ToolStripMenuItem";
            this.pNG形式ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pNG形式ToolStripMenuItem.Text = "PNG形式";
            // 
            // jPEG形式ToolStripMenuItem
            // 
            this.jPEG形式ToolStripMenuItem.Name = "jPEG形式ToolStripMenuItem";
            this.jPEG形式ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.jPEG形式ToolStripMenuItem.Text = "JPEG形式";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すToolStripMenuItem,
            this.やり直しToolStripMenuItem,
            this.座標へ移動ToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.編集ToolStripMenuItem.Text = "編集";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 424);
            this.panel1.TabIndex = 1;
            // 
            // 元に戻すToolStripMenuItem
            // 
            this.元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            this.元に戻すToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.元に戻すToolStripMenuItem.Text = "元に戻す";
            // 
            // やり直しToolStripMenuItem
            // 
            this.やり直しToolStripMenuItem.Name = "やり直しToolStripMenuItem";
            this.やり直しToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.やり直しToolStripMenuItem.Text = "やり直し";
            // 
            // 座標へ移動ToolStripMenuItem
            // 
            this.座標へ移動ToolStripMenuItem.Name = "座標へ移動ToolStripMenuItem";
            this.座標へ移動ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.座標へ移動ToolStripMenuItem.Text = "座標へ移動";
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二点間の距離を測定するToolStripMenuItem});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.ツールToolStripMenuItem.Text = "ツール";
            // 
            // 二点間の距離を測定するToolStripMenuItem
            // 
            this.二点間の距離を測定するToolStripMenuItem.Name = "二点間の距離を測定するToolStripMenuItem";
            this.二点間の距離を測定するToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.二点間の距離を測定するToolStripMenuItem.Text = "二点間の距離を測定する";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SquereEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前をつけて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 画像で出力するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMP形式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNG形式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEG形式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直しToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 座標へ移動ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二点間の距離を測定するToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

