using UnityEngine;

public class SwipeMouse : MonoBehaviour
{
    private Vector2 firstPressPos;
    private Vector2 secondPressPos;
    private Vector2 currentSwipe;
    public float noneSwipeLimit;

    public enum SwipeDirection { none, up, down, left, right }

    public static SwipeDirection enumSwipe;

    private void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();


            
                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    
                    enumSwipe = SwipeDirection.up;
                }
                //swipe down
                else if (currentSwipe.y < 0 && currentSwipe.x > -0.5f)
                {
                    
                    enumSwipe = SwipeDirection.down;
                }
            

            
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    
                    enumSwipe = SwipeDirection.left;
                }
                //swipe right
                else if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    
                    enumSwipe = SwipeDirection.right;
                }
            

        }
    }
}