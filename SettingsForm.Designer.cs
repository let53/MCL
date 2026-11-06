/*
 * Created by SharpDevelop.
 * User: Галина
 * Date: 06.11.2026
 * Time: 1:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MCLP
{
	partial class SettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox Nickname;
		private System.Windows.Forms.TextBox SelectRAM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		
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
			this.Nickname = new System.Windows.Forms.TextBox();
			this.SelectRAM = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Nickname
			// 
			this.Nickname.Location = new System.Drawing.Point(12, 53);
			this.Nickname.Name = "Nickname";
			this.Nickname.Size = new System.Drawing.Size(198, 20);
			this.Nickname.TabIndex = 0;
			this.Nickname.TextChanged += new System.EventHandler(this.NicknameTextChanged);
			// 
			// SelectRAM
			// 
			this.SelectRAM.Location = new System.Drawing.Point(499, 53);
			this.SelectRAM.Name = "SelectRAM";
			this.SelectRAM.Size = new System.Drawing.Size(198, 20);
			this.SelectRAM.TabIndex = 1;
			this.SelectRAM.Text = "1020";
			this.SelectRAM.TextChanged += new System.EventHandler(this.SelectRAMTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Введите ник";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(495, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 41);
			this.label2.TabIndex = 3;
			this.label2.Text = "Введите RAM";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(562, 290);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 49);
			this.button1.TabIndex = 4;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 344);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SelectRAM);
			this.Controls.Add(this.Nickname);
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
