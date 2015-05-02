using UnityEngine;
using System.Collections;

public class zoomOut : MonoBehaviour {

	void OnMouseDown() {
		back ();
		Destroy (gameObject);
		GameDoor.zoomedIn = false;
	}

	void back ()
	{
		// Zoom Camera in
		Vector3 pos;
		pos.x = 0;
		pos.y = 0;
		pos.z = -6;
		GameObject player = GameObject.FindWithTag ("Player");
		player.transform.position = pos;
	}
}
