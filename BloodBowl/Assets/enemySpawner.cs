using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
	public GameObject enemyModel;
	private int spawnRate;
	// Use this for initialization
	void Start () {
		spawnRate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnRate > 200) {
			Instantiate (enemyModel, transform.position, transform.rotation);
			spawnRate = 0;
		} else {
			spawnRate++;
		}
	}
}
