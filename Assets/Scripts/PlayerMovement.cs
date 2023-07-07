using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb; // Player parameters
    public float forwardForce = 2000f; // Forward motion force
    public float sidewaysForce = 500f; // Horizontal movement force

    // FixedUpdate is used here since we are working with physics
    void FixedUpdate() {
        // Adding power forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Adding power to the right if user pressing "d" button
        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // X-add power, 0, 0, force mode - strength mode - without using body weight
        }
        
        // Adding power to the left if user pressing "a" button
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Сheck if the object did not fall
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame(); // Contacting the game manager to notify the end of the game.
        }
    }

}
