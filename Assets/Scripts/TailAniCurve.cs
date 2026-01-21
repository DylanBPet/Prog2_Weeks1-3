using System.Security.Cryptography;
using UnityEngine;

public class TailAniCurve : MonoBehaviour
{
    //The t that we will apply to our curve.evaluate
    public float animationTime = 0;

    //The boolean telling animation time when to count up and when to count down
    bool hasReachedTop = true;

    //The above position for the Lerp, this will be the parent object above the gameobject
    public Transform abovePos;

    //The above Below for the Lerp, this will be the CHILD object below the gameobject
    public Transform belowPos;

    //the animation curve that will be applied to the game object
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //if hasReachedTop is true, count down instead of up (so lerp goes downwards)
        if (hasReachedTop)
        {
            animationTime -= Time.deltaTime;
        }
        //if hasReachedTop is not true, Count up (so lerp goes upwards)
        else
        {
            animationTime += Time.deltaTime;
        }

        //if animationTime is equal to or less than 0, set it to 0 and reverse hasReached top
        //this is so the code knows when the lerp has been completed and to switch so it can count back up
        if(animationTime <= 0)
        {
            //setting animation time to 0 so if it counts under it still works
            animationTime = 0;
           hasReachedTop = !hasReachedTop;
        }

        //telling the code if the lerp has been completed (1) revers hasReacehd top so it counts back down
        if(animationTime >= 1)
        {
            //setting animation time to 1 so if it counts over it still works
            animationTime = 1;
            hasReachedTop = !hasReachedTop;
        }
                //The lerp, abovePos is the parent object above, belowPos is the child oject below.
                //AnimationTime is counting up and down by Time.deltaTime depending on what the boolean hasReachedTop says
            transform.position = Vector2.Lerp(abovePos.position, belowPos.position, curve.Evaluate(animationTime));
        
    }
}
