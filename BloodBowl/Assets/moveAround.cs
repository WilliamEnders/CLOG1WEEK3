using UnityEngine;
using System.Collections;

public class moveAround : MonoBehaviour {
	public int speed;
	public int enemiesOnScreen;
	private bool touchGround;
	public GameObject grenadeModel;
	// Use this for initialization
	void Start () {
		touchGround = false;
		speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = transform.position + ( (transform.right / 10) *  Input.GetAxis("Horizontal"));
		transform.position = transform.position + ( (transform.forward / speed) *  Input.GetAxis("Vertical"));
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.down * 2);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up * 2);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			if(touchGround){
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 300, 0));
				touchGround = false;
			}
		}
		if (Input.GetKey (KeyCode.Q)) {
			//transform.Rotate(Vector3.down * 2);
			transform.position = transform.position - (transform.right / speed);
		
		}
		if (Input.GetKey (KeyCode.E)) {
			//transform.Rotate(Vector3.up * 2);
			transform.position = transform.position + (transform.right / speed);
		
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Instantiate(grenadeModel, transform.position + Vector3.forward, transform.rotation);
			
		}
	}
	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.gameObject.tag == "Ground") {
			touchGround = true;
		}
	}
}
