using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleController : MonoBehaviour {

    
    float x;
    float y;
    public float speed = 1.0f;
    bool isLocked;
    public Collider2D correctPlace;
    //public AnimationClip anim;

    // Use this for initialization
    void Start()
    {
        isLocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        //if (isGameOver())
        {
            //Debug.Log("GameOver!");
        }
    }
    void OnMouseDrag()
    {
        if (!isLocked)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 16.01f));
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision == correctPlace) && !Input.GetMouseButtonDown(0))
        {
            this.transform.position = collision.transform.position;
            isLocked = true;
        }
    }

    //bool isGameOver()
    //{
    //    foreach (var item in puzzles.puzzlesList)
    //    {
    //        if (!item.isLocked) return false;
    //    }
    //    return true;
    //}

}
