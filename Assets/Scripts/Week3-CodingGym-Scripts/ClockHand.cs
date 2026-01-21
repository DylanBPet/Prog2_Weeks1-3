using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public float speed;
    Vector3 newRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newRotation = transform.eulerAngles;

        newRotation.z += speed * Time.deltaTime;

        transform.eulerAngles = newRotation;


    }
}
