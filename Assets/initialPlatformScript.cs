using UnityEngine;

public class initialPlatformScript : MonoBehaviour
{
    public float moveDownSpeed = 2f;
    public float deadZone = -7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * moveDownSpeed) * Time.deltaTime; //moves the platform downward at a fixed speed

        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
