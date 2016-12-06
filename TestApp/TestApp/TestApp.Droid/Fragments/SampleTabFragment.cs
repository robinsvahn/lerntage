using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace TestApp.Droid.Fragments
{
    internal class SampleTabFragment : SupportFragment
    {
        private View _myView;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _myView = inflater.Inflate(Resource.Layout.Tab, container, false);

            var sampleTextView =
                _myView.FindViewById<TextView>(Resource.Id.sampleTextView);
                sampleTextView.Text = "sample fragment text";

            return _myView;
        }
    }
}