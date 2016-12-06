using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using TestApp.Droid.Fragments;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;

namespace TestApp.Droid.Adapters
{
    class PageAdapter : FragmentPagerAdapter
    {
        public PageAdapter(SupportFragmentManager fm) : base(fm)
        {
            //_fragments = new List<SupportFragment>();
            //_fragments.Add(new SampleTabFragment());
            //_fragments.Add(new SampleTabFragment());
            Fragments = new List<SupportFragment>();
            FragmentNames = new List<string>();
        }

        public List<SupportFragment> Fragments { get; set; }
        public List<string> FragmentNames { get; set; }

        public override int Count
        {
            get
            {
                return Fragments.Count;
            }
        }


        public override SupportFragment GetItem(int position)
        {
            return Fragments[position];
        }

        public void AddFragment(SupportFragment fragment, string name)
        {
            if (fragment == null) return;
            Fragments.Add(fragment);
            FragmentNames.Add(name);
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(FragmentNames[position]);
        }

        //    private int _numberOfTabs;

        //    public PageAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        //    {
        //    }

        //    public PageAdapter(FragmentManager fm) : base(fm)
        //    {
        //    }

        //    public override int Count { get; }

        //    public override Fragment GetItem(int position)
        //    {
        //        switch (position)
        //        {
        //            case 0:
        //                SampleTabFragment tab1 = new SampleTabFragment();
        //                return tab1;
        //            case 1:
        //                SampleTabFragment tab2 = new SampleTabFragment();
        //                return tab2;
        //            default:
        //                return null;
        //        }
        //    }

        //    public override Get()
        //    {
        //        return _numberOfTabs;
        //    }
        //}
    }
}
