using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCLP
{
	
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			
			InitializeComponent();
			
		}
		void NicknameTextChanged(object sender, EventArgs e)
		{
	
		}
		void SelectRAMTextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			string nickname = Nickname.Text;
			int ram = Convert.ToInt32(SelectRAM.Text);
			
			
		
	}
}
