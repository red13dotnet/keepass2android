﻿using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MonoDroidUnitTesting;
using System.Reflection;

namespace Kp2aUnitTests
{
    [Activity(Label = "MonoDroidUnit", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : GuiTestRunnerActivity
    {
        protected override TestRunner CreateTestRunner()
        {
            TestRunner runner = new TestRunner();
            // Run all tests from this assembly
            //runner.AddTests(Assembly.GetExecutingAssembly());
			runner.AddTests(new List<Type> { typeof(TestLoadDb)});
			//runner.AddTests(typeof(TestLoadDb).GetMethod("TestLoadWithPasswordOnly"));}}
            return runner;
        }
    }

}
