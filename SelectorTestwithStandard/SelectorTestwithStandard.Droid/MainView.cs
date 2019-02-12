using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Navigation;
using SelectorTestwithStandard.Core;

namespace SelectorTestwithStandard.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.view_main);
            //var droid = FindViewById<Button>(Resource.Id.droid);
            var mvvm = FindViewById<Button>(Resource.Id.mvvm);

            //droid.Click += Droid_Click;
            mvvm.Click += MvvmOnClick;
        }

        private void MvvmOnClick(object sender, EventArgs e)
        {
            var navService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
            navService.Navigate<MvvmSelectorViewModel>();
        }

        //private void Droid_Click(object sender, System.EventArgs e)
        //{
        //    StartActivity(typeof(DroidSelector));
        //}
    }
}