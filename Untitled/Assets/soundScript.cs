using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundScript : MonoBehaviour {

	private AudioSource beepSource;
	
	public AudioClip[] soundClips;

	// Use this for initialization
	void Start () {
		beepSource = (AudioSource)GetComponent(typeof(AudioSource));
		
	}
		
	void OnTriggerEnter(Collider Triggercollider){
		AudioClip randomClip = soundClips [Random.Range(0, soundClips.Length)];
		
		beepSource.clip = randomClip;
		beepSource.Play ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
