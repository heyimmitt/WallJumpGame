using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused = false;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    
    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void restart()
    {
        Time.timeScale = 1f; //resets the time before restarting
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reloads current scene
    }
}
