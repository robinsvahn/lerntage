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
using Android.Support.V4.Content;
using TestApp.Model;
using TestApp.Helpers;

namespace TestApp.Droid.Fragments
{
    public class MapViewFragment : SupportFragment, IOnMapReadyCallback, GoogleMap.IOnMapClickListener ,GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
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
            MapPins_DummyData mapPinsClass = new MapPins_DummyData(Activity);
            List<MapPin> mapPins = mapPinsClass.getMapPins();
            _myMapView = googleMap;

            googleMap.SetOnMarkerClickListener(this);

            for (MapPin pin : mapPins)
            {
                googleMap.AddMarker(new MarkerOptions()
                        .Position =new LatLng(Double.parseDouble(pin.ShopLatitude()), Double.parseDouble(pin.ShopLongitude()))
                        .Title = pin.ShopName());
            }


            //        checkPermissions();
            if (ContextCompat.CheckSelfPermission(Activity, Manifest.Permission.AccessFineLocation)
                    == PackageManager.PERMISSION_GRANTED)
            {
                googleMap.MyLocationEnabled = true;

                BuildGoogleApiClient();

                _myGoogleApiClient.Connect();

            }
            else
            {
                onRequestPermissionsResult(3, new String[] { "android.permission.ACCESS_FINE_LOCATION" }, new int[] { 1 });
            }
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
    }
}