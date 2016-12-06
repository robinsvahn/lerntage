using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Model
{
    class MapPin
    {
        public MapPin(string shopName, double shopLatitude, double shopLongtitude)
        {
            ShopName = shopName;
            ShopLatitude = shopLatitude;
            ShopLongtitude = shopLongtitude;
        }

        public string ShopName { get; set; }
        public double ShopLatitude { get; set; }
        public double ShopLongtitude { get; set; }
    }
}
