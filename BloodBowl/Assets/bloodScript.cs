using UnityEngine;
using System.Collections;

public class bloodScript : MonoBehaviour {
	private int bloodLife;
	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody> ().AddForce (Vector3.left * 3000);
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitSphere * 100);
		GetComponent<Rigidbody> ().AddTorque (Random.insideUnitSphere * 100);
	}
	
	// Update is called once per frame
	void Update () {
		if (bloodLife == 50) {
			Destroy (gameObject);
		} else {
			bloodLife++;
		}
	}
}
