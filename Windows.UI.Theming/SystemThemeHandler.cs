using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.UI.Theming
{
    public class SystemThemeHandler
    {
        public static Theme AppTheme { get; private set; }
        public static Theme SystemTheme { get; private set; }
        public static void InitTheme()
        {
            var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            if (key != null)
            {
                var registryValueObject = key.GetValue("AppsUseLightTheme");
                var systemThemeRegistryValueObject = key.GetValue("SystemUsesLightTheme");
                if (registryValueObject == null)
                {
                    return;
                }
                if (systemThemeRegistryValueObject == null)
                {
                    return;
                }

                var registryValue = (int)registryValueObject;
                if (registryValue == 0)
                {
                    AppTheme = Theme.Dark;
                }
                else
                {
                    AppTheme = Theme.Light;
                }

                var registryValue2 = (int)systemThemeRegistryValueObject;
                if (registryValue2 == 0)
                {
                    SystemTheme = Theme.Dark;
                }
                else
                {
                    SystemTheme = Theme.Light;
                }
            }
        }
        public static void RegisterEvents()
        {
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }
        public static event EventHandler OnThemeChanged;


        private static void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            switch (e.Category)
            {
                case UserPreferenceCategory.General:
                    if (OnThemeChanged != null)
                    {
                        InitTheme();
                        OnThemeChanged.Invoke(sender, e);
                    }
                    break;
            }
        }
    }
}
