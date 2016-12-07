using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Gms.Maps.Model;
using Android.Runtime;
using Android.Views;
using Java.Lang;
using TestApp.Droid.Helpers;
using String = System.String;
using TestApp.Model;

namespace TestApp.Model
{
    class PopUpWindowDialog : AlertDialog
    {
        private MapPin _markerShop;
        private string _name;

        public PopUpWindowDialog(Context context, Marker marker) : base(context)
        {
            _markerShop = GetShopByName(marker.Title);
            _name = marker.Title;

            setContent();
        }

        //This method simply sets the Title and Message with info from the Shop.
        private void setContent()
        {
            this.SetTitle(_markerShop.ShopName);
            this.SetMessage("Latitude: " + _markerShop.ShopLatitude + "\r\n"
                    + "Longtitude: " + _markerShop.ShopLongtitude);

            Window window = this.Window;
            WindowManagerLayoutParams wlp = window.Attributes;
            wlp.Gravity = GravityFlags.Bottom;

            window.Attributes = wlp;
        }

        private MapPin GetShopByName(string name)
        {
            #region
            //try
            //{
            //    ShopRepository shopRepo = new ShopRepository(getOwnerActivity());
            //    return shopRepo.getShop(name);
            //}
            //catch (SQLException e)
            //{
            //    return null;
            //}
            #endregion
            MapPins_DummyData pinClass = new MapPins_DummyData();
        return pinClass.Pins.First(x => x.ShopName == name);
        }
    }
}
