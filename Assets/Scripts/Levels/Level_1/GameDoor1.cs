using UnityEngine;
using System.Collections;

/*This zooms in on the door once the player has selescted it
 */
public class GameDoor1 : MonoBehaviour {

	public static bool zoomedIn = false;
	public GameObject back;
	
	void OnMouseDown ()
	{
		zoomIn ();
		Instantiate (back);
	//These are the mouse click commands 	
	}
	
	void zoomIn ()
	{
		// Zoom Camera in
		Vector3 pos;
		pos.x = 0;
		pos.y = 0;
		pos.z = -3;
		GameObject player = GameObject.FindWithTag ("Player");
		player.transform.position = pos;
		zoomedIn = true;
	}
}
