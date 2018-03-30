using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter1 : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (transform.position.x, transform.position.y + 1f, transform.position.z);
	}
//	void OnTriggerEnter (collider bullet) {
//		if (bullet.gameObject.name == "Target");
//	}
}
