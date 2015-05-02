using UnityEngine;
using System.Collections;

public class lvl3Door : MonoBehaviour {

	public int waitTime;

	void OnMouseDown()
	{
		if (iManager.equiped) { // if an item is equiped, check if it is the correct item
			if (iManager.equipedItem.tag == "key") { // if the key is equiped
				openDoor ();
					}
				}
	}

	void openDoor()
	{
		this.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 0; // open door (move it behined other sprites)
		Destroy (iManager.equipedItem); // destroy the key
		iManager.equiped = false; // item is no longer equiped
		iManager.equipedItem = null; // set item to NULL
		GameManager.level_4_complete = true;
		StartCoroutine(wait ());
	}


	//The player is taken to a "Level Complete" Screen
	IEnumerator wait ()
	{
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("LevelCompletion");
	}


}
