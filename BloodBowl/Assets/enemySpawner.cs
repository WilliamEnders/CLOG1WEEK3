using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
	public GameObject enemyModel;
	private int spawnRate;
	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Main Camera");
		spawnRate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnRate > 200) {
			if (player.GetComponent<moveAround> ().enemiesOnScreen != 5) {
				Instantiate (enemyModel, transform.position, transform.rotation);
				player.GetComponent<moveAround> ().enemiesOnScreen++;
				spawnRate = 0;
			}
		} else {
			spawnRate++;
		}
	}
}
