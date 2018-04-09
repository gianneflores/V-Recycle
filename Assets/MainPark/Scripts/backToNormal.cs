using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToNormal : MonoBehaviour {

	public GameObject normalEnvironment;
	public GameObject grossEnvironment; 

	// Use this for initialization
	void Start () {
//		normalEnvironment.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
				normalEnvironment.SetActive (true);
				grossEnvironment.SetActive (false);
		}	
	}
}
