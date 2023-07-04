using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // FixedUpdate is used here since we are working with physics
    void FixedUpdate() {
        // Adding power forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Adding power to the right if user pressing "d" button
        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        // Adding power to the left if user pressing "a" button
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Сheck if the object did not fall
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
