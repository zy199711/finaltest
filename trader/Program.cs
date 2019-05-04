using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using trader.KLine;

namespace trader
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            //update();

            //Application.Run(new KLineForm("C:\\Users\\Jack\\Desktop\\trader\\KLine\\rb1609_d1.txt"));
            
			Application.Run(new FormTrade());
		}
	}
}
