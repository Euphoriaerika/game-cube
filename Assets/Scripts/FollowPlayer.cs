using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    
    public Transform player; // Player coordinates
    public Vector3 offset; // Parameters for shifting the camera relative to the player

    // ?Update is called once per frame
    void Update() {
        transform.position = player.position + offset; // camera coordinates change relative to player coordinates + shift coordinates
    }

}
