using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Localization : MonoBehaviour
{
    int HR = 0;
    int EN = 1;
    public void HRV()
    {
        StartCoroutine(ChangeToHR());
    }
    public void ENG()
    {
        StartCoroutine(ChangeToEN());
    }
    IEnumerator ChangeToHR()
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[HR];
        yield break;
    }
    IEnumerator ChangeToEN()
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[EN];
        yield break;
    }
}
