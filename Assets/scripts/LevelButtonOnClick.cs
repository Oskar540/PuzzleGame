using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class LevelButtonOnClick : MonoBehaviour {

    public int previousLvl;
    public int currentLvl;
    public int buttonId;
    public GameObject levelOne;

    // Use this for initialization
    void Start () {
        var s_buttonId = Regex.Match(this.name, @"\d+").ToString();
        buttonId = System.Convert.ToInt32(s_buttonId);
        currentLvl = SwipeGallery.currentLevel;
        previousLvl = SwipeGallery.currentLevel;
    }

    // Update is called once per frame
    void Update () {
        
    }

    public void GallerySwipeOnClick()
    {
        previousLvl = SwipeGallery.currentLevel;
        SwipeGallery.currentLevel = buttonId;
        currentLvl = SwipeGallery.currentLevel;
        //Debug.Log("Current: " + currentLvl);
        //Debug.Log("Previous: " + previousLvl);
        //Debug.Log(currentLvl - previousLvl);

        var diff = currentLvl - previousLvl;
        SwipeGallery.MoveGallery(levelOne, SwipeGallery.diff, diff);
    }
}
