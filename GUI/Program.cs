using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace GUI {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 form1 = new Form1();
			// Define the border style of the form to a dialog box.
			form1.FormBorderStyle = FormBorderStyle.FixedDialog;

			// Set the MaximizeBox to false to remove the maximize box.
			form1.MaximizeBox = false;

			// Set the MinimizeBox to false to remove the minimize box.
			//form1.MinimizeBox = false;

			// Set the start position of the form to the center of the screen.
			form1.StartPosition = FormStartPosition.CenterScreen;

			// Display the form as a modal dialog box.
			// form1.ShowDialog();
			Application.Run(form1);
		}
	}
}
