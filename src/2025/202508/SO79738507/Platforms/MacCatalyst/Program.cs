﻿using UIKit;

namespace SO79738507;

#pragma warning disable CS1591 // Suppressing warnings for missing XML comments on public types and members

public class Program
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}
