using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public GameObject destination = null;

	public GameObject Player = null;

	private bool startTeleport = false;
	public int num;

	// Update is called once per frame
	void Update () {
		if (startTeleport)
		{
			Player.transform.position = Vector3.Slerp( Player.transform.position, destination.transform.position, 0.05f * Time.timeScale);
			float distance = Vector3.Distance(Player.transform.position, destination.transform.position);
			if (distance < 3.0f)
			{
				startTeleport = false;
			}
		}
	}

	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)) {
			num++;
			startTeleport = true;
			}
}
}