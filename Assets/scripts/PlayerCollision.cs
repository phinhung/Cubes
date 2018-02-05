using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	public GameManager gameManager;

	private void OnCollisionEnter(Collision collisioninfo)
	{
		if (collisioninfo.collider.tag == "Obstacle") {

			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
