using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
	private int bulletLife;
	private GameObject MainCam;
	public int spreadAmount;
	public int speed;
	private bool notHit;
	// Use this for initialization
	void Start () {
		notHit = true;
		MainCam = GameObject.Find ("Main Camera");
		GetComponent<Rigidbody> ().AddTorque (Random.insideUnitSphere * 100);
		Destroy (gameObject,1f);
	}
	
	// Update is called once per frame
	void Update () {
		if (notHit) {
			transform.position += MainCam.transform.forward * speed * Time.deltaTime;
		}
	}
	void OnCollisionEnter(){
		notHit = false;
	}
}
