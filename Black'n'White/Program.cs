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

//todo: high score
//todo: icon set, language, settings
//todo: game board 6x6
//todo: sound?
