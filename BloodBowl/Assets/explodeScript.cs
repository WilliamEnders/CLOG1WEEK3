﻿using UnityEngine;
using System.Collections;

public class explodeScript : MonoBehaviour {
	private int expLife;
	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody> ().AddForce (Vector3.left * 3000);
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitSphere * 1000);
		GetComponent<Rigidbody> ().AddTorque (Random.insideUnitSphere * 100);
	}
	
	// Update is called once per frame
	void Update () {
		if (expLife == 50) {
			Destroy (gameObject);
		} else {
			expLife++;
		}
	}
}
