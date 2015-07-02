// <copyright file="TescoPOC.cs" company="Tesco">
// Copyright (c) 2014-15 All Rights Reserved
// </copyright>
// <author>Vips </author>
// <date>6/25/2015</date>
// <summary>${ClassName}.</summary>
using System;

using Xamarin.Forms;

namespace TescoPOC
{
	public class App : Application
	{
		public App ()
		{ 
			//MainPage = new UsagePageReport ();
			//MainPage = new UsagePageDetail ();
			MainPage = new UsagePage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

