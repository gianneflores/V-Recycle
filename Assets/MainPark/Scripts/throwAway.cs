using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwAway : MonoBehaviour {
	public GameObject objRemove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			objRemove.SetActive (false);
		}
	}
}
