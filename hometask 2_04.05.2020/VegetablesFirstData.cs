using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class VegetablesFirstData
    {
        private static int key = 1000;
        public int keyOut = key;
        
        public static Dictionary<int, VegetableInf> Vegetables = new Dictionary<int, VegetableInf>()
        {
                { key, new VegetableInf {
                    VegName =                "Fresh white cabbage" ,
                    VegСaloriesNumber100gr = 27,
                    VegTaste =               "slightly sweet",
                    VegSpicy =               "no",
                    VegColor =               "light green",
                    VegСountryOfOrigin =     "Belarus",
                } },

                { key+1, new VegetableInf {
                    VegName =                "Fresh carrot",
                    VegСaloriesNumber100gr = 36,
                    VegTaste =               "nice sweet",
                    VegSpicy =               "no",
                    VegColor =               "orange",
                    VegСountryOfOrigin =     "Belarus",
                } },

                { key+2, new VegetableInf {
                    VegName =                "Fresh golden onion ",
                    VegСaloriesNumber100gr = 48,
                    VegTaste =               "spicy",
                    VegSpicy =               "medium",
                    VegColor =               "light golden",
                    VegСountryOfOrigin =     "Belarus",
                } },

                { key+3, new VegetableInf {
                    VegName =                "Fresh red tomatoes",
                    VegСaloriesNumber100gr = 18,
                    VegTaste =               "sweetish",
                    VegSpicy =               "no",
                    VegColor =               "red",
                    VegСountryOfOrigin =     "Ukraine",
                } },

                { key+4, new VegetableInf {
                    VegName =                "Sunflower oil",
                    VegСaloriesNumber100gr = 884,
                    VegTaste =               "pleasant taste",
                    VegSpicy =               "no",
                    VegColor =               "golden",
                    VegСountryOfOrigin =     "Ukraine",
                } },

                { key+5, new VegetableInf {
                    VegName =                "Fresh white garlic",
                    VegСaloriesNumber100gr = 149,
                    VegTaste =               "burning peculiar",
                    VegSpicy =               "high",
                    VegColor =               "white",
                    VegСountryOfOrigin =     "China",
                } },

                 { key+6, new VegetableInf {
                    VegName =                "Fresh red onion",
                    VegСaloriesNumber100gr = 42,
                    VegTaste =               "sweet and delicate",
                    VegSpicy =               "low",
                    VegColor =               "violet-burgundy",
                    VegСountryOfOrigin =     "Russia",
                } },

                  { key+7, new VegetableInf {
                    VegName =                "Сanned peas",
                    VegСaloriesNumber100gr = 55,
                    VegTaste =               "soft and delicate",
                    VegSpicy =               "no",
                    VegColor =               "green",
                    VegСountryOfOrigin =     "Poland",
                } },

                  { key+8, new VegetableInf {
                    VegName =                "Canned corn",
                    VegСaloriesNumber100gr = 58,
                    VegTaste =               "sweetish",
                    VegSpicy =               "no",
                    VegColor =               "yellow",
                    VegСountryOfOrigin =     "France",
                } },

                  { key+9, new VegetableInf {
                    VegName =                "Cheese Feta",
                    VegСaloriesNumber100gr = 264,
                    VegTaste =               "salty",
                    VegSpicy =               "no",
                    VegColor =               "white",
                    VegСountryOfOrigin =     "Greece",
                } },

                   { key+10, new VegetableInf {
                    VegName =                "Hot chili pepper",
                    VegСaloriesNumber100gr = 40,
                    VegTaste =               "very burning",
                    VegSpicy =               "very high",
                    VegColor =               "red",
                    VegСountryOfOrigin =     "India",
                } },
        };
    }
}

