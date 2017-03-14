/*
 * Created by SharpDevelop.
 * User: Peter Kastberger
 * Date: 14.03.2017
 * Time: 20:00
 * 
 * 
 * Icons Set: https://openclipart.org/user-detail/shokunin
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Support_Info
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// use a SysInfo() object to get and hold the information,
			// we want to use.
			var sysinfo = new SysInfo();
			lblName.Text = sysinfo.UserName;
			lblComputer.Text = sysinfo.Computer;
			lblIP.Text = sysinfo.IPAddress;
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			Close();
		}
	}
	
	
}
