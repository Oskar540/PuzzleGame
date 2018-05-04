using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class HintControl : MonoBehaviour {

    public GameObject HintImage;
    private static int HintsLeft = 5;
    public int AmountOfHints = 5;

    // Use this for initialization
    void Start () {
       
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    public void onHeldDown()
    {
        if(HintsLeft > 0)
        {
            HintImage.SetActive(true);
            HintsLeft--;
        }
    }

    public void onRelease()
    {
        HintImage.SetActive(false);
    }

    public void ResetHints()
    {
        HintsLeft = AmountOfHints;
    }
}
