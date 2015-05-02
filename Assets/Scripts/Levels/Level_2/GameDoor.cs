using UnityEngine;
using System.Collections;

public class GameDoor : MonoBehaviour {

	public int waitTime;
	public static bool zoomedIn = false;
	public GameObject back;

	void OnMouseDown ()
	{
		zoomIn ();
		Instantiate (back);

	}

	void zoomIn ()
	{
		// Zoom Camera in
		Vector3 pos;
		pos.x = -2;
		pos.y = 0;
		pos.z = -2.5f;
		GameObject player = GameObject.FindWithTag ("Player");
		player.transform.position = pos;
		zoomedIn = true;
	}


}
