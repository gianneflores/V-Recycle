using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class mouseClick : MonoBehaviour {
	public GameObject objStays;
	public GameObject objDisappear;
	public float distance;
	public bool didReAppear = false;
	public bool canDrag = false; 
	private float m_waitInSeconds   = 5.0f;
	private float StartTime         = 0.0f;
	private LineRenderer moveLine;
//	public Text comments;


	void Start () {
		StartTime = Time.time + m_waitInSeconds;
//		comments.text = ""; 
//		moveLine = GetComponent<LineRenderer> ();

	}


	void Update () {
//		if (Input.GetButtonDown "Fire1") && Time.time > nextFire) {
//		} else {
//			moveLine.SetPosition (1, hit.point + (vrCam.transform.forward*moveRange));
//		}
		
	}

	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)) {
			if (didReAppear == false) {
				Invoke ("Reappear", 2); // will reappear in 5 seconds
				objStays.SetActive (false); // disappears
				objDisappear.SetActive (false);
			}

			objStays.SetActive(false);
		}
	}
		

	void Reappear(){
		objStays.SetActive(true); // I'm back!
		didReAppear = true;
		canDrag = true;

	}

	void SetCountText(){
//		if (didReAppear == true) {
//			comments.text = "Click where to throw away garbage";
//		}
	}

}