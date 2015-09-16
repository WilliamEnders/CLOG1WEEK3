using UnityEngine;
using System.Collections;

public class enemyFollow : MonoBehaviour {
	public GameObject bloodModel;
	private GameObject target;
	private bool isHit;
	public int enemyHealth;
	public bool notDead;
	// Use this for initialization
	void Start () {
		notDead = true;
		isHit = false;
		target = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.06f);
		if (isHit) {
			transform.position += Random.insideUnitSphere / 10;
			Instantiate (bloodModel, transform.position, transform.rotation);
		}
	}

	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.gameObject.tag == "Bullet" || collisionInfo.gameObject.tag == "Explosion") {
			if(enemyHealth <= 0){
			Destroy(collisionInfo.gameObject);
				if(notDead){
			target.GetComponent<moveAround>().enemiesOnScreen -= 1;
					notDead = false;
				}
			Destroy(gameObject);
			}
			else{
				Destroy(collisionInfo.gameObject);
				isHit = true;
				enemyHealth -= 10;
				gameObject.GetComponent<MeshRenderer>().material.color = new Color(.5f,0,0,1);
			}
		}
	}
}
