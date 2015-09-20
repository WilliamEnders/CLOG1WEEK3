using UnityEngine;
using System.Collections;

public class spawnBullet : MonoBehaviour {
	public GameObject bulletModel;
	public int ammoNum;
	// Update is called once per frame
	void Start () {
		ammoNum = 10000000;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			if(ammoNum > 0){
				ammoNum--;
				Instantiate(bulletModel, transform.position, transform.parent.rotation);
			}
		}

		if (Input.GetKeyDown (KeyCode.Mouse1)) {
			GetComponentInParent<moveAround>().speed /= 3;
			transform.parent.localPosition = new Vector3(0f,-0.25f,0.2f);
			bulletModel.GetComponent<bulletScript>().spreadAmount = 100;

		}
		if (Input.GetKeyUp (KeyCode.Mouse1)) {
			GetComponentInParent<moveAround>().speed = 5;
			transform.parent.localPosition = new Vector3(0.48f,-0.36f,0.48f);
			bulletModel.GetComponent<bulletScript>().spreadAmount = 8;
		}
	}
}
