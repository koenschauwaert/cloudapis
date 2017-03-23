using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using XamarinAllianceApp.Helpers;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Controllers
{
    public class MenuService
    {
        /// <summary>
        /// Get the list of characters
        /// </summary>
        /// <returns>ObservableCollection of Character objects</returns>
        public async Task<ObservableCollection<Menu>> GetMenuAsync()
        {
            var menu = await ReadMenuFromFile();
            return new ObservableCollection<Menu>(menu);
        }

        /// <summary>
        /// Get the list of characters from an embedded JSON file, including their child entities.
        /// </summary>
        /// <returns>Array of Character objects</returns>
        private async Task<Menu[]> ReadMenuFromFile()
        {
            var assembly = typeof(MenuService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(Constants.MenuFilename);
            string text;

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = await reader.ReadToEndAsync();
            }

            var menu = JsonConvert.DeserializeObject<Menu[]>(text);
            return menu;
        }
    }
}
