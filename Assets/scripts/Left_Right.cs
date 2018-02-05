using UnityEngine;

public class Left_Right : MonoBehaviour {

	public Rigidbody rb;
	public float sidewaysforce = 500f;

	public void Right()
	{
			rb.AddForce (sidewaysforce* Time.deltaTime,0,0, ForceMode.VelocityChange);

	}

	public void Left()
		{
			rb.AddForce (-sidewaysforce* Time.deltaTime,0,0, ForceMode.VelocityChange);

		}
}
