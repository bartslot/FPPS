using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () 
	{
				
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0)) 
		{
	//		print ("Shoot!");
			GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward + new Vector3(0,1,0), Quaternion.identity);
			Rigidbody bulletRigidbody = (Rigidbody)bullet.GetComponent (typeof(Rigidbody));

			bulletRigidbody.AddForce (transform.forward * 2000, ForceMode.Force);
		}
		if (Input.GetMouseButtonDown (1))
		{
			RaycastHit hitInfo;
			if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo)) {
				
				if(hitInfo.collider.gameObject.name == "Target") 
				{
					Destroy (hitInfo.collider.gameObject);
				}
			}
		}
	//	Time.timeScale = 0.1f;
	}
}
