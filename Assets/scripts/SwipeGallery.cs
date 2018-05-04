using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeGallery : MonoBehaviour {

    public GameObject[] levelsList;
    public static int currentLevel = 1;
    public GameObject[] levelsButtons;

    public static float diff = -650;

    // Use this for initialization
    void Start () {
        currentLevel = 1;
        for (int i = 1; i < levelsList.Length; i++)
        {
            levelsList[i].GetComponent<RectTransform>().localPosition.Set(diff * i, 0, 0);
        }
    }
    
    // Update is called once per frame
    void Update () {

        if (SwipeMouse.enumSwipe == SwipeMouse.SwipeDirection.left)
        {

            ++currentLevel;
            //Debug.Log("Swiped to left: " + currentLevel);
            if (currentLevel <= 3)
            {
                MoveGallery(levelsList[0], diff, 1);
            }
            else --currentLevel;
        }
        if (SwipeMouse.enumSwipe == SwipeMouse.SwipeDirection.right)
        {
            --currentLevel;
            //Debug.Log("Swiped to right: " + currentLevel);
            if (currentLevel >= 0)
            {
                MoveGallery(levelsList[0], diff, -1);
            }
            else ++currentLevel;
            
        }

        ButtonsControl();
    }


    public void ButtonsControl()
    {
        if((currentLevel - 1) >= 0 && (currentLevel - 1) <= levelsButtons.Length)
        {
            foreach (var item in levelsButtons)
            {
                item.GetComponent<RectTransform>().localScale = new Vector3(0.2f, 0.2f, 1.0f);
                var handlec = item.GetComponent<Button>().colors;
                handlec.normalColor = Color.grey;
                item.GetComponent<Button>().colors = handlec;
            }

            levelsButtons[currentLevel - 1].GetComponent<RectTransform>().localScale = new Vector3(0.25f, 0.25f, 1.0f);
            var color = levelsButtons[currentLevel - 1].GetComponent<Button>().colors;
            color.normalColor = Color.white;
            levelsButtons[currentLevel - 1].GetComponent<Button>().colors = color;

        }
    }

    public static void MoveGallery(GameObject listlevels, float difference, int factor)
    {
        difference *= factor;
        listlevels.GetComponent<RectTransform>().anchoredPosition =
            new Vector3(listlevels.GetComponent<RectTransform>().anchoredPosition.x + difference, 0, 0);
        SwipeMouse.enumSwipe = SwipeMouse.SwipeDirection.none;
    }
}
