// <copyright file="TopupPage.xaml.cs" company="PayLess">
// Copyright (c) 2014-15 All Rights Reserved
// </copyright>
// <author>Vips </author>
// <date>6/25/2015</date>
// <summary>${ClassName}.</summary>
using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace TescoPOC
{
	public partial class UsagePage : ContentPage
	{
		private Label TestLabel;
		public UsagePage ()
		{
			InitializeComponent ();
		}
		public void InitializeComponent()
		{
			try {
				this.LoadFromXaml (typeof(UsagePage));
			} catch (Exception ex) {
				int i = 0;
				i++;
			}
//			TestLabel = this.FindByName<Label>("TestLabel");
//			TestLabel.Text = "Text changed";
		}
	}
}

