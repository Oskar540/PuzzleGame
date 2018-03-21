using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeGallery : MonoBehaviour {

    public GameObject[] levelsList;
    SwipeMouse sw;

    public float diff = -650;

    // Use this for initialization
    void Start () {
        for (int i = 1; i < levelsList.Length; i++)
        {
            levelsList[i].GetComponent<RectTransform>().localPosition.Set(diff * i, 0, 0);
        }
    }
    
    // Update is called once per frame
    void Update () {

        if (SwipeMouse.enumSwipe == SwipeMouse.SwipeDirection.left)
        {
            
            levelsList[0].GetComponent<RectTransform>().anchoredPosition = 
            new Vector3(levelsList[0].GetComponent<RectTransform>().anchoredPosition.x + diff, 0, 0);
            SwipeMouse.enumSwipe = SwipeMouse.SwipeDirection.none;

        }
        if (SwipeMouse.enumSwipe == SwipeMouse.SwipeDirection.right)
        {
            
            levelsList[0].GetComponent<RectTransform>().anchoredPosition =
            new Vector3(levelsList[0].GetComponent<RectTransform>().anchoredPosition.x - diff, 0, 0);
            SwipeMouse.enumSwipe = SwipeMouse.SwipeDirection.none;
        }

    }
}
