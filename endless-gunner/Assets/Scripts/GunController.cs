using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour
{
	[SerializeField] Transform barrelEnd;

	[SerializeField] float timeBetweenShots = .75f;
	float timer;

	[SerializeField] GameObject bulletPrefab;

	void Awake()
	{
		timer = 0f;
	}

	void Update()
	{
		Shoot();
	}

	void Shoot()
	{
		timer += Time.deltaTime;

		if (timer >= timeBetweenShots)
		{
			Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);

			timer = 0f;
		}
	}
}
