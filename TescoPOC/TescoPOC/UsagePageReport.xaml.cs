// <copyright file="UsagePageReport.xaml.cs" company="Tesco">
// Copyright (c) 2014-15 All Rights Reserved
// </copyright>
// <author>Vips </author>
// <date>6/29/2015</date>
 
using System; 

using Xamarin.Forms;
using Xamarin.Forms.Xaml; 

namespace TescoPOC
{
	public partial class UsagePageReport : ContentPage
	{
		public UsagePageReport ()
		{
			InitializeComponent ();
		}

		public void InitializeComponent()
		{
			this.LoadFromXaml (typeof(UsagePageReport));
		}
	}
}

