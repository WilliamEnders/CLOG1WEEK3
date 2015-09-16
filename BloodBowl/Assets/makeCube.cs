using UnityEngine;
using System.Collections;

public class makeCube : MonoBehaviour {
	public GameObject cubeToSpawn;
	// Update is called once per frame
	void Update () {
	//when i press the G key
		if (Input.GetKey (KeyCode.G)) {
			//spawn pill
			//Instantiate(gameObject , Vector 3 position , Quaternion rotation);
			Instantiate(cubeToSpawn, Random.insideUnitSphere * 10, transform.rotation);
		}
	}
}
