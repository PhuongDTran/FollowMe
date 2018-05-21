using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace UIPrototype
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            if(Device.OS == TargetPlatform.iOS)
            {
                Console.WriteLine("on ios");
                mainGrid.IsVisible = false;
                MyMap.HasZoomEnabled = true;
                MyMap.HasScrollEnabled = true;
            }
            else if (Device.OS == TargetPlatform.Android)
            {
                Console.WriteLine("on android");
            }
        }
    }
}
