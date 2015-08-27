using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	[SerializeField] Transform targetTransform;
	[SerializeField] float smoothing = 5f;

	Vector3 offset;

	void Awake()
	{
		offset = transform.position - targetTransform.position;
	}

	void FixedUpdate()
	{
		Vector3 targetCameraPosition = targetTransform.position + offset;

		transform.position = Vector3.Lerp(transform.position, targetCameraPosition, smoothing * Time.deltaTime);
	}
}
