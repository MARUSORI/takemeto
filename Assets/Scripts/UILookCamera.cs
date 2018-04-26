using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (GameObject.FindGameObjectWithTag("MainCamera").transform);
	}
}
