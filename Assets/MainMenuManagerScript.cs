using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class MainMenuManagerScript : MonoBehaviour
{
    //method to start the game by loading to the main scene
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitGame() 
    {
        Application.Quit();
    }
}
