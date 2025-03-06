using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 5f;
    public bool isOnLeftWall = true;
    public bool isOnWall = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // gets reference to rb
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            if (isOnLeftWall) { //jumping and switching of walls 
                rb.linearVelocity = new Vector2(jumpForce, jumpForce);
                isOnLeftWall = false;
            }
            else {
                rb.linearVelocity = new Vector2(-jumpForce, jumpForce);
                isOnLeftWall = true;
            }
        }
    }
}
