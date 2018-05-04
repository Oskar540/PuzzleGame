using UnityEngine;
using UnityEngine.UI;

public class CheckLenguage : MonoBehaviour
{
    //public string PolishText;
    //public string EnglishText;
    //public string GermanyText;

    public Sprite BtnImageEng;
    public Sprite BtnImagePl;
    public Sprite BtnImageGer;


    // Update is called once per frame
    private void Update()
    {
        switch (WhichLanguage.currectLanguage)
        {
            case WhichLanguage.eLanguages.English:
                //this.GetComponent<Text>().text = EnglishText;
                this.GetComponent<Image>().sprite = BtnImageEng;
                break;

            case WhichLanguage.eLanguages.Polish:
                // -----> this.GetComponent<Text>().text = PolishText;
                //this.GetComponent<Text>().text = EnglishText;
                this.GetComponent<Image>().sprite = BtnImagePl;
                break;

            case WhichLanguage.eLanguages.Germany:
                //this.GetComponent<Text>().text = GermanyText;
                this.GetComponent<Image>().sprite = BtnImageGer;
                break;

            default:
                //this.GetComponent<Text>().text = EnglishText;
                this.GetComponent<Image>().sprite = BtnImageEng;
                break;
        }
    }
}