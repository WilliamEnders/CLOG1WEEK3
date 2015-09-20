using UnityEngine;
using System.Collections;

public class bloodScript : MonoBehaviour {
	private int bloodLife;
	// Use this for initialization
	void Start () {
		Destroy (gameObject,0.5f);
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitSphere * 100);
		GetComponent<Rigidbody> ().AddTorque (Random.insideUnitSphere * 100);
	}
}
