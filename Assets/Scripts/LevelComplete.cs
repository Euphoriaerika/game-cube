using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    // The function of loading the next scene.
    public void LoadNewLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Move to the next scene using +1 index navigation
    }

}
