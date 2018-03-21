using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameEventCon : MonoBehaviour {

    GameObject[] placesList;
    public GameObject timeObj;
    float gameTime;
    bool allisCorrect;
    bool timesUp;
    public GameObject loseScreen;
    public GameObject winScreen;
    

	// Use this for initialization
	void Start () {
        placesList = GameObject.FindGameObjectsWithTag("place");
        
        timesUp = false;
        allisCorrect = false;
        loseScreen.active = false;
        winScreen.active = false;
    }
	
	// Update is called once per frame
	void Update () {
        gameTime = timeObj.GetComponent<TimerController>().secondsLimit;
        if (gameTime > 0)
        {
            timesUp = false;

            foreach (var item in placesList)
            {
                if (item.GetComponent<EndGameCon>().isCorrect)
                {
                    allisCorrect = true;
                }
                else
                {
                    allisCorrect = false;
                    break;
                }
            }
        }
        if (gameTime <= 0) timesUp = true;


        if (allisCorrect && !timesUp)
        {
            winScreen.active = true;
        }
        if(timesUp)
        {
            loseScreen.active = true;
        }
    }
}
