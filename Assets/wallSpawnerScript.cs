using System.Threading;
using UnityEditor.Rendering;
using UnityEngine;

public class wallSpawnerScript : MonoBehaviour
{
    public GameObject walls;
    public float spawnRate = 2;
    public float timer = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnWall();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime; // increases the timer by a number regardless of frame rate
        }
        else 
        {
            spawnWall();
            timer = 0; //timer is reset to 0 after each creation of wall
        }
    }
    void spawnWall() 
    {
        Instantiate(walls, transform.position, transform.rotation);  // spawns walls at the obejct holding the script (wall spawner)    
    }
}
