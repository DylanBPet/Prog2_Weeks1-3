using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public bool wKeyIsPressed = false;
    public bool aKeyIsPressed = false;
    public bool dKeyIsPressed = false;
    public bool sKeyIsPressed = false;
    public float speed = 5f;
    public float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wKeyIsPressed = Keyboard.current.wKey.isPressed;
        aKeyIsPressed = Keyboard.current.aKey.isPressed;
        sKeyIsPressed = Keyboard.current.sKey.isPressed;
        dKeyIsPressed = Keyboard.current.dKey.isPressed;


        if(wKeyIsPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime;//take your current position
        }                                                               //and add transform.up(1,0,0) * speed

        if (sKeyIsPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;//take your current position
        }                                                               //and subtract transform.up(1,0,0) * speed

        if (aKeyIsPressed)
        {
            Vector3 newRotation = transform.eulerAngles;     //make the variable the same as your current rotation
            newRotation.z += rotationSpeed * Time.deltaTime; //add how much you want to rotate
            transform.eulerAngles = newRotation;             //apply it back to your current rotation
        }

        if (dKeyIsPressed)
        {
            Vector3 newRotation = transform.eulerAngles;     //make the variable the same as your current rotation
            newRotation.z -= rotationSpeed * Time.deltaTime; //add how much you want to rotate
            transform.eulerAngles = newRotation;             //apply it back to your current rotation
        }
    }
}
