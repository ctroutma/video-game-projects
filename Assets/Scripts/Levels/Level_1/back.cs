using UnityEngine;
using System.Collections;
/*This class zooms the camera out when the player selects the back button
 */
public class back : MonoBehaviour {
	//These are the mouse click commands
	void OnMouseDown() {
		zoomOut ();
		Destroy (this.gameObject);
		GameDoor1.zoomedIn = false;
	}
	
	void zoomOut ()
	{
		// Zoom Camera out
		Vector3 pos;
		pos.x = 0;
		pos.y = 0;
		pos.z = -6;
		GameObject player = GameObject.FindWithTag ("Player");
		player.transform.position = pos;
	}
}
