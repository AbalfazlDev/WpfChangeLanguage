using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
namespace WpfTestChangeLanguage
{
    public class LocalizationService
    {
        private ResourceManager _resourceManager;
        private CultureInfo _currentCulture;

        public LocalizationService()
        {
            _resourceManager = new ResourceManager("WpfTestChangeLanguage.Resources.Strings", typeof(LocalizationService).Assembly);
            _currentCulture = CultureInfo.CurrentCulture;
        }

        public string GetString(string key)
        {
            return _resourceManager.GetString(key, _currentCulture);
        }

        public void SetCulture(string cultureCode)
        {
            _currentCulture = new CultureInfo(cultureCode);
        }
    }
}
