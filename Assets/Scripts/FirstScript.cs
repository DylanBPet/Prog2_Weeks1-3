using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //variable for the speed
    public float speed = 0.5f;

    //boolean for if i want it to have random position or not
    public bool randomPosition = true;

    //vector for the bottom (y = 0) and the leftmost (x=0)
    Vector2 bottomLeft;

    //vector for the top (y = screen.hight) and the rightmost (x=screen.width)
    Vector2 topRight;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //applying values to bottomLeft. needs to be in pixels
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);

        //applying values to topRIght. needs to be in pixels
        topRight = Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width, Screen.height));

        //if randomposition = true, make the position random
        if (randomPosition)
        {
            transform.position = (Vector2)transform.position + Random.insideUnitCircle * 2;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //newpos variable is equal to transform.position from the previous frame
        Vector2 newPos = transform.position;

        //add speed to newpos x value, multiplied by time since last frame
        newPos.x += speed * Time.deltaTime;

        //new variable screenpos, it is where the object is in PIXELS
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //if object hits left of screen
        if (screenPos.x < 0)
        {
            //change newPos to 0
            newPos.x = bottomLeft.x;

            //reverse direction
            speed = speed * -1;
        }

        //if object hits right of screen
        if (screenPos.x > Screen.width)
        {
            //change newPos to width of the screen
            newPos.x = topRight.x;

            //reverse directions
            speed = speed * -1;

        }

        //make the position whatever newPos is
        transform.position = newPos;

    }
}
