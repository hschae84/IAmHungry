using UnityEngine;
using System.Collections;

public class CatMotor : MonoBehaviour
{
	//옵션 조절
	public float gravityMultiplier = 4;
	public float jumpHeight = 1.5f;

	//모터 값
	private Rigidbody2D motorRigidbody;
	private Vector2 velocity;

	private class JumpState
	{
		public bool pressed;
		public bool held;
		//public int numAirJumps = 1;

		public float height;
	}

	JumpState jumpState = new JumpState();


	public void Start()
	{
		motorRigidbody = GetComponent<Rigidbody2D> ();
		velocity = motorRigidbody.velocity;
	}

	public void FixedUpdate()
	{
		HandleJumping ();

		motorRigidbody.velocity = velocity;
	}

	public void Jump()
	{
		jumpState.pressed = true;
		jumpState.height = jumpHeight;
		jumpState.held = true;
	}

	public void HandleJumping()
	{
		velocity.y = CalculateSpeedNeeded (jumpState.height);
	}

	private float CalculateSpeedNeeded(float height)
	{
		return Mathf.Sqrt(-2 * height * gravityMultiplier * Physics2D.gravity.y);
	}
}
