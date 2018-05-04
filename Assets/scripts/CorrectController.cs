using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectController : MonoBehaviour {

    public GameObject[] placeList;

    void Start()
    {
        placeList = GameObject.FindGameObjectsWithTag("place");
    }

    void Update()
    {
        if(!Input.GetMouseButtonDown(0))
        foreach (var item in placeList)
        {
            if(!item.GetComponent<EndGameCon>().isCorrect)
                {
                    item.gameObject.SetActive(false);
                    item.gameObject.SetActive(true);
                }
        }
    }

    // Update is called once per frame
    //   void FixedUpdate () {

    //}
}
