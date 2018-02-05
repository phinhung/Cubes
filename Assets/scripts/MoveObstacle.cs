using UnityEngine;

public class MoveObstacle : MonoBehaviour {

	public Rigidbody rigi;
	public float Force = 50f;

	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.left * Time.deltaTime);
	}
}
