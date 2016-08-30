using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour
{
	public float moveSpeed = 5;
	public float jumpSpeed = 100;

	CatMotor motor;

	void Start()
	{
		motor = GetComponent<CatMotor> ();
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = transform.position + new Vector3(moveSpeed * Time.deltaTime, 0, 0);
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = transform.position + new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
			transform.eulerAngles = new Vector3 (0, 180, 0);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//rigidbody.AddForce (new Vector2(0, jumpSpeed * Time.deltaTime), ForceMode2D.Impulse);
			motor.Jump();
		}
	}
}
