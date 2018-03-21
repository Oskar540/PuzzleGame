using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerController : MonoBehaviour {

    public float secondsLimit = 60;
    private float timer;
    public Text timerText;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(secondsLimit % 60 >= 10) timerText.text = ((int)secondsLimit / 60) + ":" + (secondsLimit % 60);
        else timerText.text = ((int)secondsLimit / 60) +":0" + (secondsLimit % 60);

        timer += Time.deltaTime;
        if (secondsLimit > 0 && timer >= 1)
        {
            
            secondsLimit--;
            timer = 0;
        }
        //Debug.Log(secondsLimit);

	}



}
