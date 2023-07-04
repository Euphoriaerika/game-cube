using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public TMPro.TextMeshProUGUI endText;
    public Score scoring;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if(!gameHasEnded){
            scoring.scoreCalculation = false;
            gameHasEnded = true;
            endText.text = "Game Over";
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
