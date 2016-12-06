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
using TestApp.Model;

namespace TestApp.Droid.Helpers
{
    internal class MapPins_DummyData
    {
        public MapPins_DummyData()
        {
            AddPins();
        }

        public List<MapPin> Pins { get; set; }

        private void AddPins()
        {
            Pins = new List<MapPin>
            {
                new MapPin("natürli Käsehumidor Jelmoli", 47.3742433, 8.5376607),
                new MapPin("Fabrikladen natürli Zürioberland AG", 47.3900599, 8.8525027),
                new MapPin("Milchmanufaktur Einsiedeln AG", 47.1361129, 8.7464332),
                new MapPin("Molkerei Neff AG", 47.2767807, 8.9138241),
                new MapPin("Chäs-Egge", 47.4166734, 8.9691834),
                new MapPin("Käserei Hüsli", 47.329281, 8.9201852),
                new MapPin("Käse-Spezialitäten Rohner", 47.4133987, 9.0680813),
                new MapPin("Käserei Pfister GmbH", 47.2614121, 8.9672239),
                new MapPin("Amstad Chäslädeli GmbH", 47.355772, 8.56138),
                new MapPin("Chäslädeli Mönchaltorf", 47.3102817, 8.7203981)
            };

            throw new NotImplementedException();
        }
    }
}