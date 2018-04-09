using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objDisappear : MonoBehaviour {
	public bool didReAppear = false; 
	public GameObject objStays;
	public GameObject objGone;
	public int num = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void disappear(){
		num++;
		if (didReAppear == false) {
			Invoke ("Reappear", 2); // will reappear in 5 seconds
			objStays.SetActive (false); // disappears
			objGone.SetActive (false);
		}
	}

	void Reappear(){
		objStays.SetActive(true); // I'm back!
		didReAppear = true;
//		canDrag = true;

	}
}
