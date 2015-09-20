using UnityEngine;
using System.Collections;

public class coinCollect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Rotate (new Vector3 (-90,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0,0,12));
	}

	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}
}
