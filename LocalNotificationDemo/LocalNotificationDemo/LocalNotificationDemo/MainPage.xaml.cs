using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotifications;
using Xamarin.Forms;

namespace LocalNotificationDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    public void Start_Notification(object sender, EventArgs e)
	    {
	        CrossLocalNotifications.Current.Show("Title","Text");
	    }

    }
}
