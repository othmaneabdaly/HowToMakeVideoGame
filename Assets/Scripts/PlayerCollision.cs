using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    public GameManager GameManager;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        //We testing if the layer collider touch something called Obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //Disable the player movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
