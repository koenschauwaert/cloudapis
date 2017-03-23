using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XamarinAllianceApp.Models
{
    public class Menu
    {
        Int32 id;
        string dish;
        double price;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "dish")]
        public string Dish
        {
            get { return dish; }
            set { dish = value; }
        }

        [JsonProperty(PropertyName = "price")]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
