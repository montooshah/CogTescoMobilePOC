// <copyright file="Splash.cs" company="PayLess">
// Copyright (c) 2014-15 All Rights Reserved
// </copyright>
// <author>Vips </author>
// <date>6/26/2015</date>
// <summary>${ClassName}.</summary>

using System.Threading;
using Android.App;
 
using Android.OS;
 
namespace TescoPOC.Droid
{
	[Activity (Label = "Splash", MainLauncher = true, NoHistory=true, Theme="@style/Theme.Splash")]			
	public class Splash : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			Thread.Sleep(100);
			StartActivity(typeof(MainActivity));
		}
	}
}

