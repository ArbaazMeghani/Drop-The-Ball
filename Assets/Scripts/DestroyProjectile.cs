﻿using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
	}
}
