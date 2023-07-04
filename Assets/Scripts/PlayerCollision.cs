using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    
    // This function is called after the player collides with an obstacle object
    private void OnCollisionEnter(Collision collisionInfo) {
        // After a collision, the player stops
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
