using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CmlLib.Core;

namespace MCLP
{
	
	public partial class MainForm : Form
	{
		public MinecraftLauncher launcher;
		public MainForm()
		{
			
			InitializeComponent();
			var path = new MinecraftPath("./mc_data");
			launcher = new MinecraftLauncher(path);
			
		}
		void BtnPlayClick(object sender, EventArgs e)
		{
	
		}
		private async Task LoadVersions() {
			var versions = await launcher.GetAllVersionsAsync();
			foreach (var v in versions) {
				comboBox1.Items.Add(v);
		}
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		async void MainFormLoad(object sender, EventArgs e)
		{
			await LoadVersions();
		}
		void BtnSettingsClick(object sender, EventArgs e)
		{
			SettingsForm settingForm = new SettingsForm();
			settingForm.ShowDialog();
		}
		
	}
}
