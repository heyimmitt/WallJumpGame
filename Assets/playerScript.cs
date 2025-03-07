using UnityEngine;
using TMPro; //for the high score 
public class playerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 5f;
    public bool isOnLeftWall = true;
    public bool isOnWall = false;

    public float wallGravity = 0.2f;
    public float normalGravity = 1f;

    public CircleCollider2D playerCollider; //makes a variable so we can interact with the player collider 
    public LayerMask wallLayer; //makes a layer for walls 

    public TMP_Text currentScore; //to track the score the user 
    public int score = 0; //the int variable that tracks the score
    public bool isCollidingWithWall = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // gets reference to rb
        playerCollider = GetComponent<CircleCollider2D>(); // gets reference to the player collider
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnWall) 
        {
            if (isOnLeftWall) // jumping and switching of walls
            {
                rb.linearVelocity = new Vector2(jumpForce, jumpForce);
                isOnLeftWall = false;
            }
            else 
            {
                rb.linearVelocity = new Vector2(-jumpForce, jumpForce);
                isOnLeftWall = true;
            }
        }

        if (isOnWall)
        {
            rb.gravityScale = wallGravity;
        }
        else
        {
            rb.gravityScale = normalGravity;
        }
    }

    //this method will be called once the player enters collision with the wall
    //this is to increase the score 
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & wallLayer) != 0 && !isCollidingWithWall)
        {
            increaseScore();
            isCollidingWithWall = true;
        }
    }

    // method to check if the player is touching a wall
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & wallLayer) != 0) // checks if the player is colliding with a wall
        {
            isOnWall = true; // the player is on the wall
        }
    }

    // method is called when a player stops touching a wall
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & wallLayer) != 0) // checking if the player is leaving a wall
        {
            isOnWall = false;
            isCollidingWithWall = false;
        }
    }

    public void increaseScore() 
    {
        score++;
        currentScore.text = score.ToString();
    }
}
