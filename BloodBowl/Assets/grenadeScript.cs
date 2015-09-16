using UnityEngine;
using System.Collections;

public class grenadeScript : MonoBehaviour {
	public GameObject expModel;
	private bool isHit;
	private int time;
	private GameObject MainCam;

	void Start(){
		MainCam = GameObject.Find ("Main Camera");
		GetComponent<Rigidbody> ().AddForce ((MainCam.transform.forward + new Vector3(0,0.1f,0))* 1000);
		GetComponent<Rigidbody> ().AddTorque (Random.insideUnitSphere * 100);
	}

	void OnCollisionEnter(){
		isHit = true;

	}

	void Update(){
		if (isHit && time != 7) {
			Instantiate (expModel, transform.position + Random.insideUnitSphere, transform.rotation);
			Instantiate (expModel, transform.position + Random.insideUnitSphere, transform.rotation);
			Instantiate (expModel, transform.position + Random.insideUnitSphere, transform.rotation);
			Instantiate (expModel, transform.position + Random.insideUnitSphere, transform.rotation);
			Instantiate (expModel, transform.position + Random.insideUnitSphere, transform.rotation);
			Instantiate (expModel, transform.position + Random.insideUnitSphere, transform.rotation);
			time++;
		}
		if (time == 7) {
			Destroy(gameObject);
		}
	}
}
