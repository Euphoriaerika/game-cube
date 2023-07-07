using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager; // game manager object

    // The function is triggered when the player enters this object. 
    // She turns to the game manager to move to the next level.
    void OnTriggerEnter() {
        gameManager.CompleteLevel(); // Call the game manager function to switch levels.
    }

}
