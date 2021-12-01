using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizationController : MonoBehaviour
{

    void Start()
    {

        //LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
    }


    void Update()
    {
        
    }

    public void setLocalization(int locale) {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[locale];
    }

    public int getLocationCode(string locale)
    {
        if (locale == "en") {
            return 0;
        }
        else if (locale == "es") {
            return 1;
        }
        else {
            return 1;
        }
    }

        public void setLocation(string locale)
        {

            if (locale == "en")
            {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
        }
            else if (locale == "es")
            {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
        }
            else
            {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
        }
        }
}
