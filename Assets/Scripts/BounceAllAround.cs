using UnityEngine;

public class BounceAllAround : MonoBehaviour
{
    //speed variables are for how fast the object moves in the respective directions
    public float speedX;
    public float speedY;

    //the vector of the bottom left and top right of the screen so we know when object reachs any edge
    Vector2 topRight;
    Vector2 bottomLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     //setting the vectors
        bottomLeft = Camera.main.ScreenToWorldPoint (Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    }

    // Update is called once per frame
    void Update()
    {
        //This vector is where we are going to move the object to in the next frame
        Vector2 newPos = transform.position;

        //This is where the object is in PIXELS in the current frame
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //moving the position by the speed variables based on time
        newPos.x += speedX * Time.deltaTime;
        newPos.y += speedY * Time.deltaTime;

        //if the object reaches the left side of screen, bounce back
        if(screenPos.x < 0)
        {
            newPos.x = bottomLeft.x;
            speedX = speedX * -1;
        }
        //if the object reaches the bottom of screen, bounce back
        if (screenPos.y < 0)
        {
            newPos.y = bottomLeft.y;
            speedY = speedY * -1;
        }
        //if the object reaches the right side of screen, bounce back
        if (screenPos.x > Screen.width)
        {
            newPos.x = topRight.x;
            speedX = speedX * -1;
        }
        //if the object reaches the top of screen, bounce back
        if (screenPos.y > Screen.height)
        {
            newPos.y = topRight.y;
            speedY = speedY * -1;
        }

        //change the position of the object to newPos
        transform.position = newPos;

        //continue to part 2 in coding gym
    }
}
