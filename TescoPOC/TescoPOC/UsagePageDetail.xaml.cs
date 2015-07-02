// <copyright file="UsagePageDetail.xaml.cs" company="PayLess">
// Copyright (c) 2014-15 All Rights Reserved
// </copyright>
// <author>Vips </author>
// <date>6/29/2015</date>
// <summary>${ClassName}.</summary>
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TescoPOC
{
	public partial class UsagePageDetail : ContentPage
	{
		public UsagePageDetail ()
		{
			InitializeComponent ();
		}
		public void InitializeComponent()
		{
			this.LoadFromXaml (typeof(UsagePageDetail));
		}
	}
}

