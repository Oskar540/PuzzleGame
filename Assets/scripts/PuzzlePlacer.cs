using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePlacer : MonoBehaviour {

    public GameObject Listpuzzles;
    private List<GameObject> puzzles = new List<GameObject>();

	// Use this for initialization
	void Start () {
        for (int i = 1; i <= 24; i++)
        {
            puzzles.Add(GameObject.Find("slice_" + i.ToString()));
        }
        //Debug.Log("Puzzles: " + puzzles.Count);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
