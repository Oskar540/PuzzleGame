using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMagnet : MonoBehaviour {

	public GameObject magnetedObj;

	// Use this for initialization
	void Start () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		magnetedObj = collision.gameObject;
        //collision.gameObject.GetComponent<Transform>().position = (new Vector3(this.transform.position.x, this.transform.position.y, -2.770827f));

    }

    private void OnTriggerStay2D(Collider2D collision)
	{
		magnetedObj = collision.gameObject;
		Debug.Log(collision.name + " magneted with " + this.name);
		collision.gameObject.GetComponent<Transform>().position = (new Vector3(this.transform.position.x, this.transform.position.y, -2.770827f));
	}

	// Update is called once per frame
	void Update () {
		this.GetComponent<EndGameCon>().currPuzzle = magnetedObj;
	}
}
