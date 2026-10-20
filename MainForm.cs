using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;

namespace MCL
{
	
	public partial class MainForm : Form
	{
		private readonly MinecraftLauncher _launcher = new MinecraftLauncher(new MinecraftPath("minecraftl"));
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
	
		}
	}
}
