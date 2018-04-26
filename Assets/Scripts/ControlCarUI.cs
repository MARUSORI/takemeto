using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCarUI : MonoBehaviour {
	public Button circleButton;
	public Button sideUpButton;
	public Button sideDownButton;

	public Animator circleAnim;
	public Animator flowerAnim;

	private bool isCircleActive = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hitt;
		for (int i = 0; i < Input.touchCount; ++i)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast (ray, out hitt)) {
					if(hitt.transform.tag == "circleButton"){
						if (!isCircleActive) {
							isCircleActive = true;
							circleAnim.SetTrigger ("pressedTrig");
							flowerAnim.SetTrigger ("flowerOutTrig");
						} else {
							isCircleActive = false;
							circleAnim.SetTrigger ("releasedTrig");
							flowerAnim.SetTrigger ("flowerInTrig");
						}
					}
					if (hitt.transform.tag == "sideButtonUp") {
						sideUpButton.GetComponentInChildren<Text>().text = "RESERVED";
						sideUpButton.GetComponentInChildren<Text> ().color = Color.white;
					}
					if (hitt.transform.tag == "sideButtonDown") {
						sideDownButton.GetComponentInChildren<Text>().text = "CALLING ..";
					}
				}
			}

		}
		
	}
}
