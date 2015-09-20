using UnityEngine;
using System.Collections;

public class moveAround : MonoBehaviour {
	public float speed;
	public int enemiesOnScreen;
	private bool touchGround;
	public GameObject grenadeModel;
	// Use this for initialization
	void Start () {
		touchGround = false;
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (transform.right * speed * Time.deltaTime) * Input.GetAxis("Horizontal");
		transform.position += (transform.forward * speed * Time.deltaTime) *  Input.GetAxis("Vertical");

		if (Input.GetKeyDown (KeyCode.Space)) {
			if(touchGround){
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 300, 0));
				touchGround = false;
			}
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Instantiate(grenadeModel, transform.position + Vector3.forward, transform.rotation);
			
		}
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			speed = speed * 2;
		}
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			speed = speed / 2;
		}
	}
	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.gameObject.tag == "Ground") {
			touchGround = true;
		}
	}
}
