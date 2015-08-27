using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[SerializeField] float speed = 6f;

	Vector3 movement;
	Rigidbody playerRB;
	//int floorMask;

	void Awake ()
	{
		//floorMask = LayerMask.GetMask ("Floor");
		playerRB = GetComponent <Rigidbody> ();
	}

	void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		if (h != 0 || v != 0)
		{
			Move(h, v);
			Turn(h, v);
		}
	}

	void Move(float h, float v)
	{
		movement.Set(h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRB.MovePosition(transform.position + movement);
	}

	void Turn(float h, float v)
	{
		Vector3 targetDir = new Vector3(h, 0f, v);
		Quaternion targetRot = Quaternion.LookRotation(targetDir);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, 500 * Time.deltaTime);
		/*
		if (Input.GetJoystickNames().Length == 0) // No controller connected.
		{
			Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit floorHit;

			if(Physics.Raycast (camRay, out floorHit, 100f, floorMask))
			{
				Vector3 playerToMouse = floorHit.point - transform.position;
				playerToMouse.y = 0f;
				Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
				playerRB.MoveRotation (newRotation);
			}
		}
		else // There is a controller
		{

		}
		*/
	}
}
