using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeEnvironment : MonoBehaviour {

	public int count; 
	public GameObject objectsDisappear;
	public GameObject objectsShow;

	// Use this for initialization
	void Start () {
		objectsShow.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.G)) {
			Debug.Log ("DEBUG");
			objectsDisappear.SetActive (false);
			objectsShow.SetActive (true);
			
		}
			
	}


}
