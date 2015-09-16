using UnityEngine;
using System.Collections;

public class killOtherObject : MonoBehaviour {

	void OnTriggerExit(Collider otherObject){
		if (otherObject.gameObject.tag == "Pills") {
			Destroy (otherObject.gameObject);
		}
		//can destroy gameobjects, components, 

	}
}
