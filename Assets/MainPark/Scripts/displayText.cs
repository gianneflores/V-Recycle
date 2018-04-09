using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class displayText : MonoBehaviour {
	public Text comments; 
	public int count = 0;
	bool didReAppear = false;
	public GameObject devil;
	public GameObject sphere;
	public Text devilComment;


	// Use this for initialization
	void Start () {
		devil.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
//		Vector3 commentPos = Camera.main.WorldToScreenPoint (sphere.transform.position);
//		devilComment.transform.position = commentPos;
	}

	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)) {
			count++;
			if (didReAppear == false) {
				Invoke ("Reappear", 2); // will reappear in 2 seconds
			}
			comments.text = "";
			if (count == 2)
				appear ();

		}
	}


	void Reappear(){
		didReAppear = true;
		comments.text = "Click where to throw away";

	}

	void appear(){
		devil.SetActive(true);
		Vector3 commentPos = Camera.main.WorldToScreenPoint (sphere.transform.position);
		devilComment.transform.position = commentPos;
//		devilComment.text = "HOW DARE YOU?!";
		count++;
	}
}
