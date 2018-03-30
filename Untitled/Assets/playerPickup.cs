using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPickup : MonoBehaviour {

	public AudioSource beepSource;
	private Rigidbody aPickleRigidbody;
	public AudioClip[] soundClips;
   
   private GameObject aPickleObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	RaycastHit hitInfo;
	int layer = LayerMask.NameToLayer("aPickle");
		if(Input.GetMouseButtonDown(1))
		{
			if(aPickleObject == null)
			{
				if (Physics.Raycast(transform.position+ transform.forward, transform.forward,out hitInfo, 10f, 1<<layer))
				{
					aPickleObject = hitInfo.collider.gameObject;
					aPickleObject.transform.parent = transform;
					Debug.Log(hitInfo.transform.name);
					
					aPickleRigidbody = (Rigidbody)aPickleObject.GetComponent (typeof(Rigidbody));
					aPickleRigidbody.isKinematic = true;
					//AudioClip randomClip = soundClips [Random.Range(0, soundClips.Length)];
			
					//beepSource.clip = randomClip;
					//beepSource.Play ();
				}

			} 
			else {
				aPickleRigidbody.isKinematic = false;
				aPickleObject.transform.parent = null;
				aPickleObject = null;
				aPickleRigidbody = null;
			}
        }
    }
}
