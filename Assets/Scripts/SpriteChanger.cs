using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels;
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
            PickARandomSprite();
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

    }

    void PickARanodomColour()
    {
        spriteRenderer.color = Random.ColorHSV();


    }

    void PickARandomSprite()
    {
      
        randomNumber = Random.Range(0, barrels.Length);

        spriteRenderer.sprite = barrels[randomNumber];

    }
}
