using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;

using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Gms.Common.Apis;
using Android.Gms.Location.Places;
using Android.Locations;
using Android.Support.V4.Content;
using TestApp.Droid.Helpers;
using TestApp.Model;

namespace TestApp.Droid.Fragments
{
    public class MapViewFragment : SupportFragment, IOnMapReadyCallback, GoogleMap.IOnMapClickListener ,GoogleApiClient.IConnectionCallbacks,
        GoogleApiClient.IOnConnectionFailedListener, GoogleMap.IOnMarkerClickListener
    {
        private View _myView;
        private MapView _myMapView;
        private GoogleMap _myMap;
        private GoogleApiClient _myGoogleApiClient;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            _myView = inflater.Inflate(Resource.Layout.MapView, container, false);

            _myMapView = (MapView)_myView.FindViewById(Resource.Id.MapView_Map);
            _myMapView.OnCreate(savedInstanceState);
            _myMapView.OnResume();
            _myMapView.GetMapAsync(this);


            return _myView;
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            MapPins_DummyData mapPinsClass = new MapPins_DummyData();
            List<MapPin> mapPins = mapPinsClass.Pins;
            _myMap = googleMap;

            _myMap.SetOnMarkerClickListener(this);

            foreach (MapPin pin in mapPins)
            {
                googleMap.AddMarker(new MarkerOptions()
                        .SetPosition(new LatLng(pin.ShopLatitude, pin.ShopLongtitude))
                        .SetTitle(pin.ShopName));
            }


            //        checkPermissions();
            if (ContextCompat.CheckSelfPermission(Activity, Manifest.Permission.AccessFineLocation) == Permission.Granted)
            {
                googleMap.MyLocationEnabled = true;

                BuildGoogleApiClient();

                _myGoogleApiClient.Connect();

            }
            else
            {
                OnRequestPermissionsResult(3, new String[] { "android.permission.ACCESS_FINE_LOCATION" }, new Permission[] { Permission.Granted, });
            }
            //new int[] { 1 }
        }

        protected void BuildGoogleApiClient()
        {
            Toast.MakeText(Activity, "BuildGoogleApiClient", ToastLength.Short).Show();
            _myGoogleApiClient = new GoogleApiClient.Builder(Activity)
                    .AddConnectionCallbacks(this).AddConnectionCallbacks(this)
                    .AddOnConnectionFailedListener(this)
                    .AddApi()
                    .Build();
        }

        public void OnMapClick(LatLng point)
        {
            throw new NotImplementedException();
        }

        public void OnConnected(Bundle connectionHint)
        {
            throw new NotImplementedException();
        }

        public void OnConnectionSuspended(int cause)
        {
            throw new NotImplementedException();
        }

        public void OnConnectionFailed(ConnectionResult result)
        {
            throw new NotImplementedException();
        }

        public bool OnMarkerClick(Marker marker)
        {
            throw new NotImplementedException();
        }
    }
}