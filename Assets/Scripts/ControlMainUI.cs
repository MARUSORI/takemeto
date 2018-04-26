using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMainUI : MonoBehaviour {
	public GameObject buttonOne;
	public GameObject buttonSec;
	public GameObject buttonThird;
	public GameObject buttonFourth;
	public GameObject buttonFifth;
	public GameObject buttonSixth;
	public GameObject ARController;
	public GameObject voiceMenu;
	private bool isToggle = false;

	/// Pruthviraj
	public static bool isArrowActive = false;
	public static bool isCarUIActive = false;
	public static bool isKeysActive = false;
	public static bool isBeaconActive = false;
	public static bool isArriveActive = false;
	public static bool isSafeInstantiate = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void mainMenuClicked(){
		if (!isToggle) {
			isToggle = true;
			buttonOne.SetActive (true);
			buttonSec.SetActive (true);
			buttonThird.SetActive (true);
			buttonFourth.SetActive (true);
			buttonFifth.SetActive (true);
			buttonSixth.SetActive (true);
		} else {
			isToggle = false;
			buttonOne.SetActive (false);
			buttonSec.SetActive (false);
			buttonThird.SetActive (false);
			buttonFourth.SetActive (false);
			buttonFifth.SetActive (false);
			buttonSixth.SetActive (false);
		}
	}

	public void arrowButtonClicked(){
		isArrowActive = true;
		isCarUIActive = false;
		isKeysActive = false;
		isArriveActive = false;
		isBeaconActive = false;
		isSafeInstantiate = true;
	}

	public void carUIButtonClicked(){
		isArrowActive = false;
		isCarUIActive = true;
		isKeysActive = false;
		isArriveActive = false;
		isBeaconActive = false;
		isSafeInstantiate = true;
	}

	public void keysButtonClicked(){
		isArrowActive = false;
		isCarUIActive = false;
		isKeysActive = true;
		isArriveActive = false;
		isBeaconActive = false;
		isSafeInstantiate = true;
	}

	public void arriveButtonClicked(){
		isArrowActive = false;
		isCarUIActive = false;
		isKeysActive = false;
		isArriveActive = true;
		isBeaconActive = false;
		isSafeInstantiate = true;
	}

	public void beaconButtonClicked(){
		isArrowActive = false;
		isCarUIActive = false;
		isKeysActive = false;
		isArriveActive = false;
		isBeaconActive = true;
		isSafeInstantiate = true;
	}

	public void initButtonClicked(){
		voiceMenu.SetActive (true);
		mainMenuClicked ();
	}
}
