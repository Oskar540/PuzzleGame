using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckLenguage : MonoBehaviour {

    public string PolishText;
    public string EnglishText;
    public string GermanyText;


    // Update is called once per frame
    void Update () {
        
		switch (WhichLanguage.currectLanguage)
        {
            case WhichLanguage.eLanguages.English:
                this.GetComponent<Text>().text = EnglishText;
                break;
            case WhichLanguage.eLanguages.Polish:
                // -----> this.GetComponent<Text>().text = PolishText;
                this.GetComponent<Text>().text = EnglishText;
                break;
            case WhichLanguage.eLanguages.Germany:
                this.GetComponent<Text>().text = GermanyText;
                break;
            default:
                this.GetComponent<Text>().text = EnglishText;
                break;
        }
    }
}
