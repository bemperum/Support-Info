/*
 * Created by SharpDevelop.
 * User: Peter Kastberger
 * Date: 14.03.2017
 * Time: 20:00
 * 
 */
using System;
using System.Windows.Forms;

namespace Support_Info
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
