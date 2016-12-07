using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using System.Collections.Generic;
using Android.Support.V4.Widget;
using Java.Lang;
using TestApp.Droid.Adapters;
using TestApp.Droid.Fragments;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;

namespace TestApp.Droid
{
	[Activity (Label = "TestApp.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : AppCompatActivity
	{
	    protected override void OnCreate(Bundle bundle)
	    {
	        base.OnCreate(bundle);

       
            SetContentView(Resource.Layout.Main);

	        TabLayout tabLayout = (TabLayout) FindViewById(Resource.Id.tablayout_navigation);
            //tabLayout.AddTab(tabLayout.NewTab().SetText("List"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Map"));

            ViewPager viewPager = (ViewPager) FindViewById(Resource.Id.pager);

            SetupviewPager(viewPager);


            tabLayout.SetupWithViewPager(viewPager);
            #region
            //this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            //var tab = this.ActionBar.NewTab();
            //tab.SetText("Tab 1");

            //tab.TabSelected += delegate (object sender, ActionBar.ActionBar.TabEventArgs e) {
            //    e.FragmentTransaction.Add(Resource.Id.fragmentContainer,
            //    new SampleTabFragment());
            //};

            // Set our view from the "main" layout resource
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Info"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Standorte"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("QR"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Produkte"));
            //tabLayout.TabGravity = TabLayout.GravityFill;

            //        PagerAdapter
            //        viewPager.setAdapter(adapter);
            //        viewPager.addOnPageChangeListener(new TabLayout.TabLayoutOnPageChangeListener(tabLayout));
            //        viewPager.setOffscreenPageLimit(4); //Makes sure Map doesn't "disappear" after switching tabs
            //        tabLayout.setOnTabSelectedListener(new TabLayout.OnTabSelectedListener() {
            //            @Override
            //            public void onTabSelected(TabLayout.Tab tab)
            //    {
            //        viewPager.setCurrentItem(tab.getPosition());
            //    }

            //    @Override
            //                public void onTabUnselected(TabLayout.Tab tab)
            //    {

            //    }

            //    @Override
            //            public void onTabReselected(TabLayout.Tab tab)
            //    {

            //    }
            //});
            #endregion
        }

        private void SetupviewPager(ViewPager viewPager)
	    {
	        viewPager.OffscreenPageLimit = 2;

            var adapter = new PageAdapter(SupportFragmentManager);
            adapter.AddFragment(new SampleTabFragment(), "Fragment 1");
            adapter.AddFragment(new MapViewFragment(), "Fragment 2");

            viewPager.Adapter = adapter;
        }

	    // Get our button from the layout resource,
			// and attach an event to it
		//	Button button = FindViewById<Button> (Resource.Id.myButton);
			
		//	button.Click += delegate {
		//		button.Text = string.Format ("{0} clicks!", count++);
		//	};
		//}

    }
}


