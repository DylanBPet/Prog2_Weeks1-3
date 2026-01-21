using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARanodomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
         {
            //PickARanodomColour();
            if(barrels.Count > 0)
            {
                PickARandomSprite();
            }

           
         }
        


        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }

      if  (Mouse.current.leftButton.wasPressedThisFrame)
        {
            barrels.RemoveAt(0);
        }

    }

    void PickARanodomColour()
    {
        spriteRenderer.color = Random.ColorHSV();


    }

    void PickARandomSprite()
    {
      
        randomNumber = Random.Range(0, barrels.Count);

        spriteRenderer.sprite = barrels[randomNumber];

    }
}
