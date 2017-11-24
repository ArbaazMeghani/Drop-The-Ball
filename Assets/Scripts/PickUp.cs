using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	public int speed = 20;

	private GameManager gameManager;
	private AudioSource audioSource;
	private bool destroyInstance = false;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.FindGameObjectWithTag ("GameController").gameObject.GetComponent<GameManager> ();
		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	void Update() {
		if (destroyInstance && !audioSource.isPlaying)
			Destroy (gameObject);

		transform.Rotate (new Vector3(0, speed, 0) * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Projectile") && !destroyInstance) {
			audioSource.Play ();
			gameManager.AddScore();
			destroyInstance = true;
		}
	}
}
