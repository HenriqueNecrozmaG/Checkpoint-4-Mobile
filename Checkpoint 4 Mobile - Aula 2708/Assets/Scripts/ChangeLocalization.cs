using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLocalization : MonoBehaviour
{
    public void ChangeLenguage(int lenguageID)
    {
        StartCoroutine(ChangeLenguageCoroutine(lenguageID));
    }

    IEnumerator ChangeLenguageCoroutine(int localID)
    {
        yield return LocalizationSettings.InitializationOperation;

        if (localID >= 0 && localID < LocalizationSettings.AvailableLocales.Locales.Count)
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localID];
        }
    }
}
