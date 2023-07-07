using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player; // Player coordinates
    public TMPro.TextMeshProUGUI scoreText; // The value of the distance traveled count
    public bool scoreCalculation = true; // Switch for scoring state: on or off

    // ?Update is called once per frame
    void Update() {
        // Stops counting in case the player loses
        if (scoreCalculation){
            //Update score player
            scoreText.text = player.position.z.ToString("0");
        }

    }

}
