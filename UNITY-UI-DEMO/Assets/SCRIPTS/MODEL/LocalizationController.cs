using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizationController : MonoBehaviour
{

    void Start()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
    }


    void Update()
    {
        
    }

    public void setLocalization(int locale) {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[locale];
    }
}
