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
		ProgressBar ProgressBarData;
		ProgressBar ProgressBarCall;
		Image ButtonUsageReport;
		Image ButtonUsageDetails;
		Image ButtonUsagePage;
		StackLayout SlUsagePage;
		StackLayout SlUsageReport;
		StackLayout SlUsageDetail;
		TapGestureRecognizer TabButtonTouchRecognizer;
		public UsagePage ()
		{
			InitializeComponent ();
		}
		public void InitializeComponent()
		{
			try {
				this.LoadFromXaml (typeof(UsagePage));
				ProgressBarData = this.FindByName<ProgressBar>("ProgressBarData"); 
				ProgressBarCall = this.FindByName<ProgressBar>("ProgressBarCall"); 

				ButtonUsageReport = this.FindByName<Image>("UsageReportButton"); 
				ButtonUsagePage = this.FindByName<Image>("UsageButton"); 
				ButtonUsageDetails = this.FindByName<Image>("UsageDetailsButton"); 

				SlUsagePage= this.FindByName<StackLayout>("SlUsagePage");
				SlUsageReport= this.FindByName<StackLayout>("SlUsageReport");
				SlUsageDetail = this.FindByName<StackLayout>("SlUsageDetail");

				TabButtonTouchRecognizer = new TapGestureRecognizer();
				TabButtonTouchRecognizer.Tapped+= TabButtonTouchRecognizer_Tapped;
				ButtonUsageReport.GestureRecognizers.Add(TabButtonTouchRecognizer);
				ButtonUsagePage.GestureRecognizers.Add(TabButtonTouchRecognizer);
				ButtonUsageDetails.GestureRecognizers.Add(TabButtonTouchRecognizer);


			} catch (Exception ex) {
				 //TODO::Log Reporting.
				int i=0;
				i++;
			} 
		}

		void TabButtonTouchRecognizer_Tapped (object sender, EventArgs e)
		{
			Image touchImageButton = sender as Image;
			if (touchImageButton == null)
				return;
			if (touchImageButton.Id == ButtonUsageReport.Id) {
				SlUsagePage.IsVisible = false;
				SlUsageReport.IsVisible = true;
				SlUsageDetail.IsVisible = false;

				ButtonUsageReport.Source = "circle_segment_select";
				ButtonUsageReport.BackgroundColor = Color.FromHex( "#00ACEA");

				ButtonUsagePage.Source = "line_segment_unselect";
				ButtonUsagePage.BackgroundColor = Color.White;

				ButtonUsageDetails.Source = "grid_segment_unselect";
				ButtonUsageDetails.BackgroundColor = Color.White;
			}
			else if (touchImageButton.Id == ButtonUsagePage.Id) {
				SlUsagePage.IsVisible = true;
				SlUsageReport.IsVisible = false;
				SlUsageDetail.IsVisible = false;

				ButtonUsageReport.Source = "circle_segment_unselect";
				ButtonUsageReport.BackgroundColor = Color.White;

				ButtonUsagePage.Source = "line_segment_select";
				ButtonUsagePage.BackgroundColor = Color.FromHex( "#00ACEA");

				ButtonUsageDetails.Source = "grid_segment_unselect";
				ButtonUsageDetails.BackgroundColor = Color.White;
				ProgressBarCall.Progress = 0;
				ProgressBarData.Progress = 0;
				AnimateProgess ();
			}
			else if (touchImageButton.Id == ButtonUsageDetails.Id) {
				SlUsagePage.IsVisible = false;
				SlUsageReport.IsVisible = false;
				SlUsageDetail.IsVisible = true;
				ButtonUsageReport.Source = "circle_segment_unselect";
				ButtonUsageReport.BackgroundColor = Color.White;

				ButtonUsagePage.Source = "line_segment_unselect";
				ButtonUsagePage.BackgroundColor =Color.White;

				ButtonUsageDetails.Source = "grid_segment_select";
				ButtonUsageDetails.BackgroundColor = Color.FromHex( "#00ACEA");
			}			
		}

		void ButtonUsageDetails_Clicked (object sender, EventArgs e)
		{
			
		}

		/// <summary>
		/// Buttons the usage report clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void ButtonUsageReport_Clicked (object sender, EventArgs e)
		{
			SlUsagePage.IsVisible = false;
			SlUsageReport.IsVisible = true;
		}

		async void AnimateProgess ()
		{
			await ProgressBarCall.ProgressTo (0.5, 750, Easing.Linear);
			await ProgressBarData.ProgressTo (0.2, 500, Easing.Linear);
		}

		protected async override void OnAppearing ()
		{ 
			base.OnAppearing ();
			AnimateProgess ();
		}
	}
}

