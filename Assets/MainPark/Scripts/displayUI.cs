using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayUI : MonoBehaviour {

//	public string myString;
	public Text myText;
	public float fadeTime;
	public bool displayInfo;
	public int count;
	public GameObject devil;

	// Use this for initialization
	void Start () {

		myText = GameObject.Find ("Text").GetComponent<Text> ();
		myText.color = Color.clear;
		//Screen.showCursor = false;
		//Screen.lockCursor = true;
	}

	// Update is called once per frame
	void Update () 
	{

		FadeText ();

		/*if (Input.GetKeyDown (KeyCode.Escape)) 
         
                {
                        Screen.lockCursor = false;
                         
                }
                */


	}

	void OnMouseDown()
	{
		displayInfo = true;
		count++;

	}





	void FadeText ()

	{


		if(displayInfo)
		{
			if (count == 1) {
				myText.text = "HOW DARE YOU?!?!";
				myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
			}
			if (count == 2) {
				myText.text = "It's people like you why our planet is dying.";
				myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
			}
			if (count == 3) {
				myText.text = "I'll show you!!! To the future you will go where I hope you will learn and grow...";
				myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
			}

			if (count == 4) {
				myText.text = "To return Earth's fate ...";
			}
			if (count == 5) {
				myText.text = "First Clean up trash and then clean recycables. ";
			}
			if (count == 6) {
				myText.text = "You have the power to change Earth's fate. Be wise.";
				devil.SetActive(false);
			}
			if (count == 6) {
				myText.text = "";
			}
		}

		else
		{

			myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
		}




	}



}