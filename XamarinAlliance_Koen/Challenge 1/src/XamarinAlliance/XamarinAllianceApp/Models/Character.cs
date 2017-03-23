using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XamarinAllianceApp.Models
{
    public class Character
    {
        Int32 id;
        string price;
        string dish;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "price")]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        [JsonProperty(PropertyName = "dish")]
        public string Dish
        {
            get { return dish; }
            set { dish = value; }
        }
    }
}
