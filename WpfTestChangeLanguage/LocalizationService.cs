using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
namespace WpfTestChangeLanguage
{
    public static class LocalizationService
    {
        private static ResourceManager _resourceManager = _resourceManager = new ResourceManager("WpfTestChangeLanguage.Resources.Strings", typeof(LocalizationService).Assembly);
        private static CultureInfo _currentCulture = CultureInfo.CurrentCulture;

        //public static LocalizationService()
        //{
        //    _resourceManager = new ResourceManager("WpfTestChangeLanguage.Resources.Strings", typeof(LocalizationService).Assembly);
        //    _currentCulture = CultureInfo.CurrentCulture;
        //}

        public static string GetString(string key)
        {
            return _resourceManager.GetString(key, _currentCulture);
        }

        public static void SetCulture(string cultureCode)
        {
            _currentCulture = new CultureInfo(cultureCode);
        }
    }
}
