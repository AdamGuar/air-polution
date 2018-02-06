using CanIBreatheNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Logic
{
    public class AirQualityIndexTranslator
    {

        public static Dictionary<String, String> dictionary = new Dictionary<String, String>() {
            { "Bardzo dobry" , "Very good" },
            { "Dobry" , "Good" },
            { "Umiarkowany" , "Reasonable" },
            { "Dostateczny" , "Sufficient" },
            { "Zły" , "Poor"},
            { "Bardzo zły", "Very poor" }
        };


        public List<StationIndexModel> TranslateIndexes(List<StationIndexModel> indexes) {
            List<StationIndexModel> result = new List<StationIndexModel>();

            indexes.ForEach(i =>
            {
                String generalIndex = i.StationIndex.StIndexLvl.IndexLvlName;
                


            });


            return result;
        }


        public String TranslateIndex(String index) {
            String result = "";

            if (!dictionary.TryGetValue(index,out result))
            {
                return null;
            }

            return result;
        }

    }
}