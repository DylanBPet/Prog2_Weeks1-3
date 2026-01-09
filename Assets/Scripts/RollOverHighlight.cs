using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollOverHighlight : MonoBehaviour
{
    public bool mouseIsOverMe = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position (in pixles) and convert it to world space (in meters)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint (Mouse.current.position.ReadValue());

        //get the distance between the transform.position and mouse position
        float distance = Vector2.Distance(transform.position, mousePos);

        //if the distance is less than 1 meter then set mouseIsOverMe to true
        if (distance < 1)
        {
            mouseIsOverMe = true;
        }
        else
        {
            //otherwise mouseIsOverMe to false
            mouseIsOverMe = false;
        }
    }
}
