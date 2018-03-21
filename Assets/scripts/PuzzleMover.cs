using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMover : MonoBehaviour {

    float x;
    float y;

    bool isUploaded;

    private Vector3 startPos;

	// Use this for initialization
	void Start () {
		
	}

    

    // Update is called once per frame
    void Update () {

        x = Input.mousePosition.x;
        y = Input.mousePosition.y;

        if (!Input.GetMouseButtonDown(0) && (isUploaded == false))
        {
            startPos = this.GetComponent<Transform>().position;
            isUploaded = true;
            //Debug.Log("Position: " + startPos);
        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("trigger");
       if(collision.gameObject.tag == "puzzle")
        {
            //Debug.Log("Collision with: " + collision.gameObject.name);
            collision.gameObject.transform.position = startPos;
            this.transform.position = collision.gameObject.GetComponent<PuzzleMover>().startPos;
            this.isUploaded = false;
            collision.GetComponent<PuzzleMover>().isUploaded = false;
        }
    }

    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3((float)x, (float)y, 16.01f));
    }
}
