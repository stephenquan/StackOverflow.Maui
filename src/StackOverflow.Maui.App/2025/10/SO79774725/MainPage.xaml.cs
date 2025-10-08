// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using ZXing.Net.Maui;

namespace StackOverflow.Maui.App.SO79774725;

#pragma warning disable CS1591 // Suppress missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	public ZXing.Net.Maui.Controls.CameraBarcodeReaderView? BcScanner;

	public MainPage()
	{
		InitializeComponent();

		StartCamera();
	}

	void StartCamera()
	{
		BcScanner = new ZXing.Net.Maui.Controls.CameraBarcodeReaderView();
		BcScanner.Options = new ZXing.Net.Maui.BarcodeReaderOptions()
		{
			Formats = BarcodeFormats.OneDimensional | BarcodeFormat.QrCode,
			AutoRotate = true,
		};
		BcScanner.BarcodesDetected += CameraBarcodeReaderView_BarcodesDetected;
		BcScanner.IsDetecting = true;
		barcodeContentView.Content = BcScanner;
	}

	void StopCamera()
	{
		if (BcScanner is not null)
		{
			BcScanner.BarcodesDetected -= CameraBarcodeReaderView_BarcodesDetected;
			BcScanner.IsDetecting = false;
			BcScanner = null;
			barcodeContentView.Content = null;
		}
	}

	void BtSh_Clicked(object sender, EventArgs e)
	{
		StartCamera();
		BtSh.IsVisible = false;
	}

	async void CameraBarcodeReaderView_BarcodesDetected(object? sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
	{
		try
		{
			await Dispatcher.DispatchAsync(async () =>
			{
				StopCamera();
				await DisplayAlert("Test", e.Results![0].Value.ToString(), "OK");
				BtSh.IsVisible = true;
			});
		}
		catch (Exception ex)
		{
			System.Diagnostics.Trace.WriteLine($"Exception: {ex.Message}");
		}
	}
}
