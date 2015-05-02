﻿using UnityEngine;
using System.Collections;

public class Level_5_Door : MonoBehaviour {

	GameObject pic;

	void OnMouseDown() {
		pic = GameObject.Find ("Room_5.3");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 2;
		pic = GameObject.Find ("Room_5.2");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		pic = GameObject.Find ("Room_5.1");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		pic = GameObject.Find ("Room_5_Red_Light");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		pic = this.gameObject;
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		pic = GameObject.Find ("back");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 3;
		pic.gameObject.AddComponent<BoxCollider> ();
		pic = GameObject.Find ("broccoli");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("steak");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("salad");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("chicken");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("iceCream");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("candy");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("soda");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("rice");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		pic = GameObject.Find ("carrot");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		if (!Level_5_Page.inInventory) {
			pic = GameObject.Find ("Room_5_Page");
			pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
			Destroy (pic.gameObject.collider); 
		}
		pic = GameObject.Find ("Room_5_Tom_Button");
		pic.gameObject.AddComponent<BoxCollider> ();
		pic = GameObject.Find ("Room_5_Sally_Button");
		pic.gameObject.AddComponent<BoxCollider> ();
		pic = GameObject.Find ("Room_5_Bob_Button");
		pic.gameObject.AddComponent<BoxCollider> ();
		pic = GameObject.Find ("Room_5_Center_Button");
		pic.gameObject.AddComponent<BoxCollider> ();

		for (int i=0; i<9; i++) {
			pic = Level_5_Puzzle.puzzleSlotList[i];
			pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
		}

		Level_5_Buttons.changeSlotColors (); // change slot colors on start
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}