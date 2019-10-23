namespace ThreeCoordinateMainWindow
{
	partial class LoadingWindow
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
			this.pbProgress = new System.Windows.Forms.ProgressBar();
			this.msg_Progress = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pbProgress
			// 
			this.pbProgress.Location = new System.Drawing.Point(12, 33);
			this.pbProgress.Name = "pbProgress";
			this.pbProgress.Size = new System.Drawing.Size(473, 26);
			this.pbProgress.TabIndex = 0;
			// 
			// msg_Progress
			// 
			this.msg_Progress.AutoSize = true;
			this.msg_Progress.Location = new System.Drawing.Point(12, 9);
			this.msg_Progress.Name = "msg_Progress";
			this.msg_Progress.Size = new System.Drawing.Size(95, 12);
			this.msg_Progress.TabIndex = 1;
			this.msg_Progress.Text = "正在打开文件...";
			// 
			// LoadingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 71);
			this.ControlBox = false;
			this.Controls.Add(this.msg_Progress);
			this.Controls.Add(this.pbProgress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "LoadingWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Loading";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar pbProgress;
		private System.Windows.Forms.Label msg_Progress;
	}
}