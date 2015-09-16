using UnityEngine;
using System.Collections;

public class ammoPickup : MonoBehaviour {
	private GameObject gunTip;
	// Use this for initialization
	void Start () {
		gunTip = GameObject.Find ("gunTip");
	
	}
	
	// Update is called once per frame

	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.gameObject.tag == "Player") {
			gunTip.GetComponent<spawnBullet>().ammoNum += 5;
			Destroy(gameObject);
		}
	}
}
