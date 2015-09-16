using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
	private int bulletLife;
	private GameObject MainCam;
	public int spreadAmount;
	// Use this for initialization
	void Start () {
		MainCam = GameObject.Find ("Main Camera");
		GetComponent<Rigidbody> ().AddForce ((MainCam.transform.forward + (Random.insideUnitSphere / spreadAmount))* 5000);
		GetComponent<Rigidbody> ().AddTorque (Random.insideUnitSphere * 100);
	}
	
	// Update is called once per frame
	void Update () {
		if (bulletLife == 100) {
			Destroy (gameObject);
		} else {
			bulletLife++;
		}
	
	}
}
