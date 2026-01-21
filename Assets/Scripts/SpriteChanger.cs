using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARanodomColour();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Keyboard.current.anyKey.wasPressedThisFrame)
         {
             //PickARanodomColour();
         }
        */


        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }

    }

    void PickARanodomColour()
    {
        spriteRenderer.color = Random.ColorHSV();


    }
}
