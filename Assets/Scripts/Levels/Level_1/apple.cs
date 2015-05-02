using UnityEngine;
using System.Collections;
/*This class allows the player to complete the level 
 * once the apple has been chosen
 */
public class apple : MonoBehaviour {

	public int waitTime;
	public GameObject back;
	//if the game door is not zoomed in on the camera zooms in
	void OnMouseDown()
	{
		if (!GameDoor1.zoomedIn) {
			zoomIn();
			GameDoor1.zoomedIn = true;
			Instantiate (back);
		}
		
	//if the GameDoor is zoomed in on the player has an opportunity to open the door	
		else if (GameDoor1.zoomedIn) {
			GameManager.level_1_complete = true;
			back = GameObject.FindWithTag("back");
			Destroy (back);
			openDoor ();
	//When the apple is chosen the GameDoor opens which completes the level
		}
		
		
		
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
	}
	
	void openDoor ()
		//GameDoor opens
	{
		GameObject blackDoor = GameObject.FindWithTag ("openDoor");
		blackDoor.GetComponent<SpriteRenderer> ().sortingOrder = 5;
		StartCoroutine (wait ());
	}
	
	//The player is taken to a "Level Complete" Screen
	IEnumerator wait ()
	{
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("LevelCompletion");
	}

}
