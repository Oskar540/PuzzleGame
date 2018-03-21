using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMoverVer2 : MonoBehaviour {

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


        if (!Input.GetMouseButton(0) && (isUploaded == false))
        {
            startPos = this.GetComponent<Transform>().position;
            isUploaded = true;
            //Debug.Log("Position: " + startPos);

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("trigger");
        if (!Input.GetMouseButton(0) && collision.gameObject.tag == "puzzle")
        {

            //Debug.Log("Collision with: " + collision.gameObject.name);

            collision.gameObject.transform.position = startPos;
            this.transform.position = collision.gameObject.GetComponent<PuzzleMoverVer2>().startPos;
            this.isUploaded = false;
            collision.GetComponent<PuzzleMoverVer2>().isUploaded = false;
        }
    }

    void OnMouseDrag()
    {
        
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3((float)x, (float)y, 16.01f - 1.0f));
    }
}
