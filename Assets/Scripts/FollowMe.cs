using UnityEngine;

public class FollowMe : MonoBehaviour
{
    //Getting the transform of the thing we want to follow. In this case it will be the PARENT object in front of the gameobject in line
    public Transform follow;

    //This float will control the t of the lerp
    float t;

    //This will be the movespeed (how fast the object catch up to one another)
    public float moveSpeed = 2.75f;

    //The space in meters between the objects (how close or far apart objects need to be to start or stop the lerp)
    //make it public because we will need to see the effect in unity
    public float spaceBetween = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //setting time to 0 at the start of every frame
        t = 0;

        //t is equal to our move speed multiplied by time.deltatime
        t += moveSpeed * Time.deltaTime;

        //calculating the distance between gameObject and the object we are following
        float distance = Vector3.Distance(transform.position, follow.position);

        //if the distance is MORE than the space between, start the lerp
        //this way once we get close enough the objects stop
        if (distance > spaceBetween)
        {
            transform.position = Vector2.Lerp(transform.position, follow.position, t);
        }

    }
}

