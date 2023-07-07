using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false; // Switch for game state: on or off
    public TMPro.TextMeshProUGUI endText; // Game end message
    public Score scoring; // Object Score
    public float restartDelay = 1f; // Default game restart delay value.
    public GameObject completeLevelUI; // Object CompleteLevel

    // Activating the level completion window
    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    // Completion of the game and actions upon completion.
    public void EndGame() {
        if(!gameHasEnded) { // The game ends only once
            scoring.scoreCalculation = false; // Scoring stops
            gameHasEnded = true; // Turn on the option to end the game, for a one-time end of the game.
            endText.text = "Game Over"; // !!! Updating the end game message
            Invoke("Restart", restartDelay); // Call the level restart function with a delay.
        }
    }

    // Restart the level
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Contact the scene manager to restart the active scene.
    }

}
