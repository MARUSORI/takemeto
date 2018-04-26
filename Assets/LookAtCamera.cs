using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtCamera : MonoBehaviour {
	public Button andyButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (GameObject.FindGameObjectWithTag("MainCamera").transform);

		RaycastHit hitt;
		for (int i = 0; i < Input.touchCount; ++i)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast (ray, out hitt)) {
					if(hitt.transform.tag == "andyButton"){
						andyButton.GetComponentInChildren<Text>().text = "Pressed";
					}
				}
			}

		}
	}
}
