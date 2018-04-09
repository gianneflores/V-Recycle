using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickRock : MonoBehaviour {

	public GameObject happyDevil;
	public Text myText;
	public float fadeTime;
	public bool displayInfo;

	// Use this for initialization
	void Start () {
		happyDevil.SetActive (false);
		myText = GameObject.Find ("Text").GetComponent<Text> ();
		myText.color = Color.clear;
		
	}
	
	// Update is called once per frame
	void Update () {
		FadeText ();
		
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)) {
			happyDevil.SetActive (true);

				displayInfo = true;

			
	}
}

	void FadeText ()
	{


		if (displayInfo) {
			myText.text = "THANK YOU Savior of Earth's Fate\n";
			myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
		}
	}
}
