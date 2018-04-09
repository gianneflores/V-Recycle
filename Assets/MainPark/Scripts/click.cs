//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class click : MonoBehaviour {
//
//	private float nextFire;
//	private Camera vrCam;
//	private LineRenderer moveLine;
//
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Input.GetButtonDown "Fire1") && Time.time > nextFire) {
//			nextFire = Time.time + moveRate;
//			StartCoroutine (ShotEffect()));
//			Vector3 rayOrigin = vrCam.ViewportToWorldPoint(new Vector3 (.5f, .5f, 0));
//			RaycastHit hit;
//			Collider hitInfo;
//
//			moveLine.setPosition(0, start.position);
//		} 
//		
//	}
//
//
//	private IEnumerator ShotEffect()
//	{
//		// Play the shooting sound effect
////		moveAudio.Play ();
//
//		// Turn on our line renderer
//		moveLine.enabled = true;
//
//		//Wait for .07 seconds
//		yield return shotDuration;
//
//		// Deactivate our line renderer after waiting
//		moveLine.enabled = false;
//	}
//}
