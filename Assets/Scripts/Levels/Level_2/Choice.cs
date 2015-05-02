using UnityEngine;
using System.Collections;

public class Choice : MonoBehaviour {

	public int waitTime;
	public GameObject back;

	void OnMouseDown()
	{
		if (!GameDoor.zoomedIn) {
			zoomIn();
			GameDoor.zoomedIn = true;
			Instantiate (back);
		}


		else if (GameDoor.zoomedIn) {
			GameManager.level_2_complete = true;
			openDoor ();
		}



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
	}

	void openDoor ()
	{
		GameObject blackDoor = GameObject.FindWithTag ("openDoor");
		blackDoor.GetComponent<SpriteRenderer> ().sortingOrder = 5;
		StartCoroutine (wait ());
	}
	
	
	IEnumerator wait ()
	{
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("LevelCompletion");
	}

}
