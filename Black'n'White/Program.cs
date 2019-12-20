using System;
using System.Windows.Forms;

namespace BlackAndWhite
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// main entrance point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (BlackAndWhiteForm mainForm = new BlackAndWhiteForm())
			{
				Application.Run(mainForm: mainForm);
			}
		}
	}
}

//todo: rightclick on field for inverting
//todo: optimize code
//todo: highscore
//todo: iconset, language, settings
//gameboard 6x6
