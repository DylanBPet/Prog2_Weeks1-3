using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragonHeadBehavior : MonoBehaviour
{
    public float t;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = 0;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 newPos = transform.position;

        t += moveSpeed * Time.deltaTime;

        float distance = Vector2.Distance(newPos, mousePos);
         
        if(distance > 0.5)
        {
            transform.position = Vector2.Lerp(newPos, mousePos, t);
        }


    }
}
