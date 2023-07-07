using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    // When you press the "Start" button, 
    // this function is triggered, which start the game.
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Move to the next scene using +1 index navigation
    }

}
