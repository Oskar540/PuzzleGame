using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMoverVer2 : MonoBehaviour {

	float x;
	float y;
    GameObject currPlace;
	bool isUploaded;


	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;


		if (!Input.GetMouseButton(0) && (isUploaded == false))
		{
			startPos = this.GetComponent<Transform>().position;
			isUploaded = true;
			//Debug.Log("Position: " + startPos);

		}
	}


    public void OnTriggerStay2D(Collider2D collision)
	{
		//Debug.Log("trigger");
		if (!Input.GetMouseButton(0) && collision.gameObject.tag == "puzzle")
		{

			//Debug.Log(this.name + "collided with: " + collision.gameObject.name);

			collision.gameObject.transform.position = startPos;
			this.transform.position = collision.gameObject.GetComponent<PuzzleMoverVer2>().startPos;
			this.isUploaded = false;
			collision.GetComponent<PuzzleMoverVer2>().isUploaded = false;
		}

        this.transform.position.Set(this.transform.position.x, this.transform.position.y, -2.770827f);

        if (!Input.GetMouseButton(0) && collision.gameObject.tag == "place")
        {
            //Debug.Log("Current puzzle: " + this.gameObject.name + " for " + collision.gameObject.name);
            collision.gameObject.GetComponent<EndGameCon>().currPuzzle = this.gameObject;
            this.transform.position.Set(this.transform.position.x,
                                         this.transform.position.y,
                                         -2.770827f);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Input.GetMouseButton(0) && collision.gameObject.tag == "place")
        {
            //Debug.Log("Current puzzle: " + this.gameObject.name + " for " + collision.gameObject.name);
            collision.gameObject.GetComponent<PlaceMagnet>().magnetedObj = this.gameObject;
        }
    }

    void OnMouseDrag()
	{
		
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3((float)x, (float)y, 16.01f - 1.0f));
	}
}
