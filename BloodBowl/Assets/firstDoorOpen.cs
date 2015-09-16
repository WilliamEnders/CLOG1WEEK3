using UnityEngine;
using System.Collections;

public class firstDoorOpen : MonoBehaviour {
	private GameObject door;
	private GameObject gun;
	private bool use;
	private Transform button;
	// Use this for initialization
	void Start () {
		button = gameObject.transform.GetChild(0);
		use = true;
		gun = GameObject.Find ("gunBarrel");
		door = GameObject.Find ("door1");
		door.GetComponent<Animator>().speed = 0;
		gun.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerStay () {
	if (Input.GetKey (KeyCode.Mouse0) && use) {
			door.GetComponent<Animator>().speed = 1;
			gun.SetActive (true);
			use = false;
			button.localPosition = new Vector3(0,0.23f,0);
		}
	}
	void Update(){
		if (door.transform.position.y >= 3.5) {
			door.GetComponent<Animator>().speed = 0;
			gameObject.transform.position += new Vector3 (0,-0.01f,0);
		}
		if (gameObject.transform.position.y <= -2) {
			Destroy(gameObject);
		}
	}
}
