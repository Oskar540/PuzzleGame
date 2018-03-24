using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameEventCon : MonoBehaviour {

    GameObject[] placesList;
    GameObject[] puzzlesList;
    public GameObject timeObj;
    float gameTime;
    bool allisCorrect;
    bool timesUp;
    public GameObject loseScreen;
    public GameObject winScreen;
    public GameObject time_scorer;

	// Use this for initialization
	void Start () {
        placesList = GameObject.FindGameObjectsWithTag("place");
        puzzlesList = GameObject.FindGameObjectsWithTag("puzzle");
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
            timeObj.GetComponent<TimerController>().Stop();
            foreach (var item in puzzlesList)
            {
                item.GetComponent<BoxCollider2D>().enabled = false;
            }
            time_scorer.SetActive(true);
            time_scorer.GetComponent<Text>().text = timeObj.GetComponent<TimerController>().timerText.text;
        }
        if(timesUp)
        {
            loseScreen.active = true;
            foreach (var item in puzzlesList)
            {
                item.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
