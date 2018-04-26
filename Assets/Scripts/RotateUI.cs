using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUI : MonoBehaviour {
	public float rotationPerMin = 5.0f;
	public bool rotateX = false;
	public bool rotateY = true;
	public bool rotateZ = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rotateX) {
			transform.Rotate (6.0f * rotationPerMin * Time.deltaTime, 0.0f, 0.0f);
		}
		if (rotateY) {
			transform.Rotate (0.0f, 6.0f * rotationPerMin * Time.deltaTime, 0.0f);
		}
		if (rotateZ) {
			transform.Rotate (0.0f, 0.0f, 6.0f * rotationPerMin * Time.deltaTime);
		}
	}
}
