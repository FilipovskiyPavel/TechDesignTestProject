using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class Change_language_onclick : MonoBehaviour
{
    private int _count = 0;
    public void SetSelectedLocale(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }
    public void Change_Language()
    {
            if(_count == 0)
            {
                _count++;
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);
            }
            else if(_count == 1)
            {
                _count++;
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[1]);
            }
            else if(_count == 2)
            {
                _count++;
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[2]);
            }
            else if(_count == 3)
            {
                _count = 0;
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[3]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
