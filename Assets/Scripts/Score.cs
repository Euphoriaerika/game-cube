using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMPro.TextMeshProUGUI scoreText;
    public bool scoreCalculation = true;

    // Update is called once per frame
    void Update()
    {

        if (scoreCalculation){
            //Update score player
            scoreText.text = player.position.z.ToString("0");
        }

    }
}
