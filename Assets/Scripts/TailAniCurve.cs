using System.Security.Cryptography;
using UnityEngine;

public class TailAniCurve : MonoBehaviour
{
    public float animationTime = 0;
    bool hasReachedTop = true;
    public Transform abovePos;
    public Transform belowPos;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (hasReachedTop)
        {
            animationTime -= Time.deltaTime;
        }
        else
        {
            animationTime += Time.deltaTime;
        }
        if(animationTime <= 0)
        {
           animationTime = 0;
           hasReachedTop = !hasReachedTop;
        }
        if(animationTime >= 1)
        {
            animationTime = 1;
            hasReachedTop = !hasReachedTop;
        }

            transform.position = Vector2.Lerp(abovePos.position, belowPos.position, curve.Evaluate(animationTime));
        
    }
}
