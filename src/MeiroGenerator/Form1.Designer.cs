namespace MeiroGenerator
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
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(688, 534);
			this.textBox1.TabIndex = 0;
			this.textBox1.WordWrap = false;
			// 
			// numericUpDownX
			// 
			this.numericUpDownX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownX.Location = new System.Drawing.Point(544, 4);
			this.numericUpDownX.Maximum = new decimal(new int[] {
            129,
            0,
            0,
            0});
			this.numericUpDownX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownX.Name = "numericUpDownX";
			this.numericUpDownX.ReadOnly = true;
			this.numericUpDownX.Size = new System.Drawing.Size(58, 19);
			this.numericUpDownX.TabIndex = 3;
			this.numericUpDownX.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// numericUpDownY
			// 
			this.numericUpDownY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownY.Location = new System.Drawing.Point(625, 4);
			this.numericUpDownY.Maximum = new decimal(new int[] {
            129,
            0,
            0,
            0});
			this.numericUpDownY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownY.Name = "numericUpDownY";
			this.numericUpDownY.ReadOnly = true;
			this.numericUpDownY.Size = new System.Drawing.Size(58, 19);
			this.numericUpDownY.TabIndex = 4;
			this.numericUpDownY.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(608, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "x";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(688, 26);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// generateToolStripMenuItem
			// 
			this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
			this.generateToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
			this.generateToolStripMenuItem.Text = "生成(&G)";
			this.generateToolStripMenuItem.Click += new System.EventHandler(this.GenerateToolStripMenuItem_Click);
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(688, 534);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(688, 560);
			this.toolStripContainer1.TabIndex = 7;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 560);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownY);
			this.Controls.Add(this.numericUpDownX);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "迷路じぇねれ～た～";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.NumericUpDown numericUpDownX;
		private System.Windows.Forms.NumericUpDown numericUpDownY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
	}
}

