using UnityEngine;

public class wallScript : MonoBehaviour
{
    public float moveDownSpeed = 2;
    public float deadZone = -7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * moveDownSpeed) * Time.deltaTime; //moves the wall downward at a fixed speed

        if (transform.position.y < deadZone)
        {
            Destroy(gameObject); 
        }
    }
}
