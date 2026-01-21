using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragonHeadBehavior : MonoBehaviour
{
    //A float that will be used as time for the Lerp
    public float t;
    //How fast the head will follow the mouse
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //setting t to 0 at the start of every frame
        t = 0;

        //getting the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //time is equal to the movespeed multiplied by time, this is so no matter the framerate it moves smoothly
        t += moveSpeed * Time.deltaTime;

        //Calculating the distance between the objects postion and the mouse position
        float distance = Vector2.Distance(transform.position, mousePos);
         
        //if the distance is MORE than an amount, do the Lerp
        //this is so the object doesnt try to sit right underneath the mouse, it is a little offset so it appears to be following rather than controlled by the mouse
        if(distance > 0.5)
        {
            transform.position = Vector2.Lerp(transform.position, mousePos, t);
        }


    }
}
