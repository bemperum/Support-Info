/*
 * Created by SharpDevelop.
 * User: Peter Kastberger
 * Date: 14.03.2017
 * Time: 20:32
 * 
 */
using System;
using System.Net;

namespace Support_Info
{
	/// <summary>
	/// Small class with System information as public members.
	/// 	UserName
	/// 	Computer
	/// 	IPAddress
	/// </summary>
	public class SysInfo
	{
		public string UserName;
		public string Computer;
		public string IPAddress;
		
		public SysInfo()
		{
			this.UserName = GetUser();
			this.Computer = GetComputer();
			this.IPAddress = GetIP();
		}
		
		private string GetUser()
		{
			var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
			return userName;
		}
		
		private string GetComputer()
		{
			var computer = System.Environment.MachineName;
			return computer;
		}
		
		private string GetIP()
    	{
			var ips = "";
			IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(GetComputer());
			foreach (IPAddress ip in ipEntry.AddressList)
		    {
		       if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
		       {
		       	ips = ip.ToString();
		       }
		    }
			
			return ips;
    	}
	}
}
