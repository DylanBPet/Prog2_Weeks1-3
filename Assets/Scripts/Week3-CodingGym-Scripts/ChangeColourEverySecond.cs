using UnityEngine;

public class ChangeColourEverySecond : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float timer = 0;
    private bool timerComplete = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Ik this is not how you make a timer. fix this
       
        if(timerComplete)
        {
            timer = timer - Time.deltaTime;
            spriteRenderer.color = Color.blue;
            timerComplete = !timerComplete;
        }
        if(timerComplete == false)
        {
            timer = timer + Time.deltaTime;
            spriteRenderer.color = Color.red;
            timerComplete = !timerComplete;
        }

    }
}
