using UnityEngine;
using System.Collections;

public class Level_5_Buttons : MonoBehaviour {

	int waitTime = 1;
	float doorWaitTime = .25f;

	void OnMouseDown() {
		if (this.gameObject.tag == "Tom") { // Rotates Tom's food choices clockwise
		Level_5_Puzzle.puzzleSlotList [0].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [1].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [0].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [1].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [1].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [1].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [6].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [0].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild (0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [0].gameObject.transform;
		changeSlotColors();
		if (checkStatus()) {
			openDoor();
		}
		}
		else if (this.gameObject.tag == "Sally") { // Rotates Sally's food choices clockwise
		Level_5_Puzzle.puzzleSlotList [2].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [3].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [2].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [3].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [3].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [3].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [7].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [2].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild (0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [2].gameObject.transform;
		changeSlotColors();
		if (checkStatus()) {
			openDoor ();
		}
		}
		else if (this.gameObject.tag == "Bob") { // Rotates Bob's food choices clockwise
		Level_5_Puzzle.puzzleSlotList [4].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [5].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [4].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [5].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [5].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [5].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [8].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [4].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [4].gameObject.transform;
		changeSlotColors();
		if (checkStatus()) {
			openDoor();
		}
		}
		else if (this.gameObject.tag == "Center") { // Rotates the center foods clockwise
		Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [7].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild(0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [8].gameObject.transform;
		Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.transform.position = Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.position;
		Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.transform.parent = Level_5_Puzzle.puzzleSlotList [6].gameObject.transform;
		changeSlotColors();
		if (checkStatus()) {
			openDoor ();
		}
		}
	}

	public bool checkStatus() {
		if (((Level_5_Puzzle.puzzleSlotList [0].gameObject.transform.GetChild (0).gameObject.name == "steak" ||
			Level_5_Puzzle.puzzleSlotList [0].gameObject.transform.GetChild (0).gameObject.name == "salad" ||
			Level_5_Puzzle.puzzleSlotList [0].gameObject.transform.GetChild (0).gameObject.name == "broccoli") &&
			(Level_5_Puzzle.puzzleSlotList [1].gameObject.transform.GetChild (0).gameObject.name == "steak" ||
			Level_5_Puzzle.puzzleSlotList [1].gameObject.transform.GetChild (0).gameObject.name == "salad" ||
			Level_5_Puzzle.puzzleSlotList [1].gameObject.transform.GetChild (0).gameObject.name == "broccoli") &&
			(Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild (0).gameObject.name == "steak" ||
			Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild (0).gameObject.name == "salad" ||
			Level_5_Puzzle.puzzleSlotList [6].gameObject.transform.GetChild (0).gameObject.name == "broccoli")) &&
			((Level_5_Puzzle.puzzleSlotList [2].gameObject.transform.GetChild (0).gameObject.name == "chicken" ||
			Level_5_Puzzle.puzzleSlotList [2].gameObject.transform.GetChild (0).gameObject.name == "rice" ||
			Level_5_Puzzle.puzzleSlotList [2].gameObject.transform.GetChild (0).gameObject.name == "carrot") &&
			(Level_5_Puzzle.puzzleSlotList [3].gameObject.transform.GetChild (0).gameObject.name == "chicken" ||
			Level_5_Puzzle.puzzleSlotList [3].gameObject.transform.GetChild (0).gameObject.name == "rice" ||
			Level_5_Puzzle.puzzleSlotList [3].gameObject.transform.GetChild (0).gameObject.name == "carrot") &&
			(Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild (0).gameObject.name == "chicken" ||
			Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild (0).gameObject.name == "rice" ||
			Level_5_Puzzle.puzzleSlotList [7].gameObject.transform.GetChild (0).gameObject.name == "carrot")) &&
			((Level_5_Puzzle.puzzleSlotList [4].gameObject.transform.GetChild (0).gameObject.name == "soda" ||
			Level_5_Puzzle.puzzleSlotList [4].gameObject.transform.GetChild (0).gameObject.name == "candy" ||
			Level_5_Puzzle.puzzleSlotList [4].gameObject.transform.GetChild (0).gameObject.name == "iceCream") &&
			(Level_5_Puzzle.puzzleSlotList [5].gameObject.transform.GetChild (0).gameObject.name == "soda" ||
			Level_5_Puzzle.puzzleSlotList [5].gameObject.transform.GetChild (0).gameObject.name == "candy" ||
			Level_5_Puzzle.puzzleSlotList [5].gameObject.transform.GetChild (0).gameObject.name == "iceCream") &&
			(Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.name == "soda" ||
			Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.name == "candy" ||
			Level_5_Puzzle.puzzleSlotList [8].gameObject.transform.GetChild (0).gameObject.name == "iceCream"))) {
			return true;
				}
		else {
			return false;
				}
	}

	void openDoor() {
		Destroy (GameObject.Find ("Room_5_Red_Light"));
		Destroy (GameObject.Find ("Room_5_Door"));
		Destroy (GameObject.Find ("back"));
		Destroy (GameObject.Find ("Room_5.2"));
		Destroy (GameObject.Find ("Room_5_Page_Read"));
		Destroy (GameObject.Find ("PageBack"));
		Inventory_button.closeInventory ();
		GameManager.level_5_complete = true; //add when theres a level 6
		StartCoroutine (doorWait ());
	}

	IEnumerator wait ()
	{
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("LevelCompletion");
	}
	

	IEnumerator doorWait()
	{
		yield return new WaitForSeconds (doorWaitTime);
		GameObject.Find ("Room_5.3").transform.position = new Vector3 (20, 20, 0);
		StartCoroutine (wait ());
	}

	// tom: 0,1,6 sally: 2,3,7 bob: 4,5,8
	public static void changeSlotColors () {
		for (int i=0; i<9; i++) {
			GameObject slotGO = Level_5_Puzzle.puzzleSlotList[i];
			//Check if Tom has any correct
			if (i == 0) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "broccoli") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "salad") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "steak")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			if (i == 1) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "broccoli") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "salad") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "steak")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			if (i == 6) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "broccoli") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "salad") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "steak")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			// Check if Sally has any correct
			if (i == 2) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "rice") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "chicken") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "carrot")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			if (i == 3) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "rice") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "chicken") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "carrot")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			if (i == 7) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "rice") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "chicken") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "carrot")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			// Check if Bob has any correct
			if (i == 4) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "candy") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "soda") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "iceCream")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			if (i == 5) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "candy") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "soda") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "iceCream")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}
			if (i == 8) {
				if ((slotGO.transform.GetChild (0).gameObject.name == "candy") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "soda") ||
				    (slotGO.transform.GetChild (0).gameObject.name == "iceCream")) {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
				}
				else {
					slotGO.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
				}
			}

		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
