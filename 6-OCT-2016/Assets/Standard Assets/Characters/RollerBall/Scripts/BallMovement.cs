using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	private Rigidbody rigidbody;
	public float moveForce;

	void Start()
	{
		rigidbody = GetComponent < Rigidbody>();
	}

	void Update () {
		float x = Input.acceleration.y*.5f;
		float y = -Input.acceleration.x*.5f;
		rigidbody.AddForce(new Vector3 (x, 0, y) * moveForce);
	}
}
