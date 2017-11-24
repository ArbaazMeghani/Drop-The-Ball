using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

	public float speed = 10;

	private Rigidbody projectileRigidBody;

	// Use this for initialization
	void Start () {
		projectileRigidBody = GetComponent<Rigidbody> ();
		projectileRigidBody.velocity = -transform.forward * speed;
	}
}
