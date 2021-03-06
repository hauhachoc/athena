﻿using System;
using System.Collections.Generic;
using System.Linq;

using Athena.ImagePicker;
using Athena.TestHarness.Pcl;
using Athena.TestHarness.Pcl.Views;
using Microsoft.Practices.Unity;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Athena.Core.iOS;

namespace Athena.TestHarness.iOS.App
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		
		public override UIWindow Window {
			get;
			set;
		}
		
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}

		public override void FinishedLaunching (UIApplication application)
		{
			Forms.Init ();

			Athena.ImagePicker.Pcl.App.Intitialise ();

			var navigationPage = new NavigationPage (new TestHarnessPage());
			var viewController = navigationPage.CreateViewController ();

			Window = new UIWindow (UIScreen.MainScreen.Bounds);

			Window.RootViewController = viewController;
			Window.MakeKeyAndVisible ();

			Athena.ImagePicker.Pcl.App.Register<IImagePickerProvider> (
				new ImagePickerProvider (Window.RootViewController), 
				new ContainerControlledLifetimeManager());
		}
	}
}

