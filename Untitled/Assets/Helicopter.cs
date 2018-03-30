using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
 
	Random random = new Random();
	float randomNumberRotation;	
	float randomNumberScale;	

	// Use this for initialization
	void Start () {
		randomNumberRotation = Random.Range(-10, 10);
//		randomNumberScale = Random.Range(60, 1000);
	}
	
	
	// Update is called once per frame
	void FixedUpdate () {
//		transform.position = new Vector3 (transform.position.x, transform.position.y + .1f, transform.position.z);
//		transform.localScale = new Vector3 (transform.localScale.x + randomNumberScale, transform.localScale.y + randomNumberScale, transform.localScale.z + randomNumberScale);
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + randomNumberRotation, transform.eulerAngles.z);
	}
	void OnTriggerEnter (Collider bullet) {
		if (bullet.gameObject.name == "Target");
	}
}
