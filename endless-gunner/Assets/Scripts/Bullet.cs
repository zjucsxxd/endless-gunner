using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	[SerializeField] float bulletSpeed = 500f;
	
	bool bulletDropped;
	
	Rigidbody rb;
	
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		SetInitialVelocity ();
	}
	
	void Update()
	{
		LookAtMoveDirection();
	}
	
	void SetInitialVelocity()
	{
		rb.velocity = transform.forward * bulletSpeed * Time.deltaTime;
	}
	
	void LookAtMoveDirection()
	{
		transform.LookAt(transform.position + rb.velocity);
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.collider)
		{
			Destroy(this.gameObject);
		}
	}
}
