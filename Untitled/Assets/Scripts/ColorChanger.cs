using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

	public Color cubeColor = new Color();

	public Renderer cubeRenderer;

	// Use this for initialization
	void Start () {
		cubeRenderer.material.color = cubeColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
