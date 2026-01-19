using UnityEngine;

public class FollowMe : MonoBehaviour
{
    public Transform follow;
    float t;
    public float moveSpeed = 2;
    public float spaceBetween = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = 0;
        t += moveSpeed * Time.deltaTime;

        float distance = Vector3.Distance(transform.position, follow.position);

        if (distance > spaceBetween)
        {
            transform.position = Vector2.Lerp(transform.position, follow.position, t);
        }

    }
}

