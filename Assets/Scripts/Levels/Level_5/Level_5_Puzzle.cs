using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level_5_Puzzle : MonoBehaviour {

	public GameObject puzzleSlotPreFab;
	public Sprite whiteCircle;

	private float[,] loc = new float[9,2] {
		{-7.07f, 8.73f},
		{-5.81f, 10.16f},
		{-2.8f, 10.05f},
		{-1.4f, 8.59f},
		{-3.32f, 4.61f},
		{-5.34f, 4.69f},
		{-5.23f, 8.24f},
		{-3.32f, 8.24f},
		{-4.26f, 6.3f} };


	private string[] foodChoice = new string[9] {
		"broccoli",
		"candy",
		"carrot",
		"chicken",
		"iceCream",
		"rice",
		"salad",
		"soda",
		"steak" };

	public static List<GameObject> puzzleSlotList;

	//private float cSize = 1.800598f;

	void initializePuzzleSlot() {
		puzzleSlotList = new List<GameObject> ();
		for (int i=0; i<9; i++) {
			Vector3 pos = new Vector3(loc[i,0], loc[i,1], 0); // new position for slot
			GameObject puzzleSlot = Instantiate (puzzleSlotPreFab) as GameObject; // instantiate slot prefab
			GameObject puzzleDoor = GameObject.Find ("Room_5.3"); // get object to set as parent
			GameObject food = GameObject.Find (foodChoice[i]); // get the food choice object
			puzzleSlot.transform.parent = puzzleDoor.transform; // set the door as parent of slot
			puzzleSlot.transform.position = pos; // put the slot in the correct position
			food.gameObject.transform.parent = puzzleSlot.transform; // set the parent of the food choice to the slot
			food.transform.position = puzzleSlot.transform.position; // set the food choice to the position of the slot
			puzzleSlotList.Add(puzzleSlot); // add the slot to the puzzle slot list
		}

	}

	// Use this for initialization
	void Start () {
		initializePuzzleSlot ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
