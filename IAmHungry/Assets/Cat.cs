using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour
{
	public float moveSpeed = 5;
	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = transform.position + new Vector3(moveSpeed * Time.deltaTime, 0, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = transform.position + new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
		}
	}
}
