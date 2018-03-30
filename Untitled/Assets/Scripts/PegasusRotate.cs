using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegasusRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {

//		randomNumberScale = Random.Range(60, 1000);
	}
	
	
	// Update is called once per frame
	void FixedUpdate () {
//		transform.position = new Vector3 (transform.position.x, transform.position.y + .1f, transform.position.z);
//		transform.localScale = new Vector3 (transform.localScale.x + randomNumberScale, transform.localScale.y + randomNumberScale, transform.localScale.z + randomNumberScale);
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + 0.2f, transform.eulerAngles.z);
	}
}
