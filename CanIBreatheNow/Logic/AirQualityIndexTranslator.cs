using CanIBreatheNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Logic
{
    public class AirQualityIndexTranslator
    {

        public static Dictionary<string, string> dictionary = new Dictionary<string, string>() {
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
                string generalIndex = i.StationIndex.StIndexLvl.IndexLvlName;
                generalIndex = TranslateIndex(generalIndex) != null ? TranslateIndex(generalIndex) : generalIndex;
                i.StationIndex.StIndexLvl.IndexLvlName = generalIndex;

                result.Add(i);

            });


            return result;
        }


        public String TranslateIndex(string index) {
            string result = "";

            if (!dictionary.TryGetValue(index,out result))
            {
                return null;
            }

            return result;
        }

    }
}