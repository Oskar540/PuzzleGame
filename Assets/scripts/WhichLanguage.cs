using UnityEngine;

public class WhichLanguage : MonoBehaviour
{
    public enum eLanguages
    {
        Polish, English, Germany
    }

    public static eLanguages currectLanguage;

    public void PolishBtn()
    {
        currectLanguage = eLanguages.Polish;
    }

    public void EnglishBtn()
    {
        currectLanguage = eLanguages.English;
    }

    public void GermanyBtn()
    {
        currectLanguage = eLanguages.Germany;
    }
}