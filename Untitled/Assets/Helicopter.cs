using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position = new Vector3 (transform.position.x, transform.position.y + .1f, transform.position.z);
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + 10f, transform.eulerAngles.z);
	}
}
