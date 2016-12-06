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
using TestApp.Droid.Fragments;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace TestApp.Droid.Adapters
{
    class PageAdapter : FragmentStatePagerAdapter
    {
        private List<Fragment> _fragments;
        private int _fragmentCount;

        public PageAdapter(FragmentManager fm) : base(fm)
        {
            _fragments = new List<Fragment>();
            _fragments.Add(new SampleTabFragment());
            _fragments.Add(new SampleTabFragment());

            _fragmentCount = _fragments.Count;
        }

        public override int Count
        {
            get { return _fragmentCount; }
        }


        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return _fragments[position];
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
