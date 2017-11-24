using UnityEngine;
using System.Collections;

public class ContactSound : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Projectile"))
			audioSource.Play ();
	}
}
