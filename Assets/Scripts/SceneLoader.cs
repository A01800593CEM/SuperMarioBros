using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class SceneLoader : MonoBehaviour
{
    // Method to quit the game
    public void Quit()
    {
        Debug.Log("Game is quitting...");
        Application.Quit();
    }

    // Method to load the "Game" scene
    public void LoadScene(string sceneName)
    {
        Debug.Log("Loading 'Game' scene...");
        SceneManager.LoadScene(sceneName);
    }

    // Method to show a canvas
    public void ShowCanvas(Canvas canvas)
    {
        if (canvas != null)
        {
            canvas.gameObject.SetActive(true);
            Debug.Log("Canvas shown: " + canvas.name);
        }
    }

    // Method to hide a canvas
    public void HideCanvas(Canvas canvas)
    {
        if (canvas != null)
        {
            canvas.gameObject.SetActive(false);
            Debug.Log("Canvas hidden: " + canvas.name);
        }
    }
}
