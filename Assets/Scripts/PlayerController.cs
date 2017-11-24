using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 5.0f;
	public Transform projectileSpawn;
	public float fireRate = 1;
	public GameObject projectile;

	private float nextFireTime;
	private Rigidbody playerRigidBody;
	private GameManager gameManager;

	void Start() {
		nextFireTime = 0.0f;
		playerRigidBody = GetComponent<Rigidbody> ();
		gameManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager> ();
	}

	void Update() {
		if (Input.GetButton ("Fire1") && Time.time > (nextFireTime+fireRate) ) {
			nextFireTime = Time.time ;
			Instantiate (projectile, projectileSpawn.position, projectileSpawn.rotation);
			gameManager.UpdateThrows();
		}
	}

	void FixedUpdate() {
		float horizontalMovement = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (horizontalMovement, 0.0f, 0.0f) * speed * Time.deltaTime;
		playerRigidBody.MovePosition (transform.position + movement);
	}
}
