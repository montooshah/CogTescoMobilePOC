// <copyright file="TitleBar.xaml.cs" company="PayLess">
// Copyright (c) 2014-15 All Rights Reserved
// </copyright>
// <author>Vips </author>
// <date>6/25/2015</date>
// <summary>${ClassName}.</summary>
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TescoPOC
{
	public partial class TitleBar : ContentView
	{
		private Label TitleLabel;
		public TitleBar ()
		{
			InitializeComponent ();
		}
		public void InitializeComponent()
		{
			this.LoadFromXaml(typeof(TitleBar));
			TitleLabel = this.FindByName<Label>("TestLabel");
			TitleLabel.Text = "Sample Title";
		}
		public string Title
		{
			get{				
				return TitleLabel.Text;
			}
			set{
				TitleLabel.Text = value;
			}
		}
	}
}

