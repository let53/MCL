/*
 * Created by SharpDevelop.
 * User: Галина
 * Date: 05.11.2026
 * Time: 23:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MCLP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button BtnPlay;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button BtnSettings;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnPlay = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.BtnSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnPlay
			// 
			this.BtnPlay.Location = new System.Drawing.Point(325, 180);
			this.BtnPlay.Name = "BtnPlay";
			this.BtnPlay.Size = new System.Drawing.Size(256, 70);
			this.BtnPlay.TabIndex = 0;
			this.BtnPlay.Text = "play";
			this.BtnPlay.UseVisualStyleBackColor = true;
			this.BtnPlay.Click += new System.EventHandler(this.BtnPlayClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(325, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(256, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(325, 150);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(256, 24);
			this.progressBar1.TabIndex = 2;
			// 
			// BtnSettings
			// 
			this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Default;
			this.BtnSettings.Location = new System.Drawing.Point(12, 12);
			this.BtnSettings.Name = "BtnSettings";
			this.BtnSettings.Size = new System.Drawing.Size(125, 44);
			this.BtnSettings.TabIndex = 3;
			this.BtnSettings.Text = "Settings";
			this.BtnSettings.UseVisualStyleBackColor = true;
			this.BtnSettings.Click += new System.EventHandler(this.BtnSettingsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 262);
			this.Controls.Add(this.BtnSettings);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.BtnPlay);
			this.Name = "MainForm";
			this.Text = "MCLP";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
