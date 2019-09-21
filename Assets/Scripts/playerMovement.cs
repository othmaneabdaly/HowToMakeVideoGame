using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    private float forwardForce = 1000f;
    private float sidewaysForce = 100f;
    public string MoveLeft = "q";
    public string MoveRight = "d";
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey(MoveRight))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(MoveLeft))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
