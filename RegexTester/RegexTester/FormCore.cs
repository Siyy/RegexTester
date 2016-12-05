using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace Jiuyong
{
	public static partial class Core
	{
		public static void SetLanguage( Form form, CultureInfo language)
		{
			ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
			Thread.CurrentThread.CurrentUICulture = language;
			Queue  cs =new Queue((ICollection )form.Controls);
			//cs.Enqueue(this);
			resources.ApplyResources(form, "$this");
			while(cs.Count > 0)
			{
				var c = cs.Dequeue() as Control;
				foreach(Control ci in c.Controls)
				{
					cs.Enqueue(ci);
				}
				resources.ApplyResources(c, c.Name);
			}
		}
	}
}
