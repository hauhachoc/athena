﻿using System;
using System.Collections.Generic;
using Athena.Core.Pcl.Views;
using Xamarin.Forms;

namespace Athena.TestHarness.Pcl.Views
{	
	public partial class TestHarnessPage : ContentPageBase
	{	
		public TestHarnessPage ()
		{
			InitializeComponent ();

			ViewModel.View = this;
		}
	}
}

