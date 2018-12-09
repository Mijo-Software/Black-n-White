using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Black_n_White
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Black_n_WhiteForm());
		}
	}
}
