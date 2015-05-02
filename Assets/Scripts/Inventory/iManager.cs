using UnityEngine;
using System.Collections;

public class iManager : MonoBehaviour {

	public static GameObject equipedItem;
	public static bool equiped = false;


	// Use this for initialization
	void Start () {

	}

	public static int getNextSlot(){ // used for getting index of next available slot to store items in inventory
		int i = 0;
		while (Inventory.slotList[i].gameObject.GetComponent<slotScript>().hasItem == true) { // while the next slot has an item, keep searching for empty slot
			i++;
				}
		return i; // return the index of next empty slot
		}
	
	// Update is called once per frame
	void Update () {
		if (equiped) {
			// Get the current screen position of the mouse from Input
			Vector3 mousePos2D = Input.mousePosition;	// 1
			
			// The Camera's z position sets how far to push the mouse into 3D
			mousePos2D.z = -Camera.main.transform.position.z;	// 2
			
			// Convert the point from 2D screen space into 3D game world space
			Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);	// 3
			
			// Move the x position of this Basket to the x position of the Mouse
			
			Vector3 pos = equipedItem.transform.position;
			pos.x = mousePos3D.x;
			pos.y = mousePos3D.y;
			equipedItem.transform.position = pos;
				}
	}

	public static void AddToInventory(GameObject item) {
		GameObject slot = Inventory.slotList [getNextSlot()]; // get gameobject of next empty slot
		item.transform.parent = slot.transform; // set the parent of the item adding to inventory
		item.transform.position = slot.transform.position; // set the correct position of item
		slot.gameObject.GetComponent<slotScript> ().hasItem = true; // register the slot as occupied
		Vector3 pos = new Vector3 (0, 0, -5); // initialize vector position for new box collider position
		item.gameObject.GetComponent<BoxCollider> ().center = pos; // put the item box collider in front of the slot collider
		item.GetComponent<SpriteRenderer> ().sortingOrder = 55; // put the sprite on top
		Destroy (item.gameObject.transform.parent.collider); // remove the slot collider component
	}

	public static void equipObject(GameObject item) {
		equipedItem = item; // set the current equiped item
		Destroy (item.collider); // remove the collider to be able to click on other objects while equiped
		item.gameObject.transform.parent.gameObject.GetComponent<slotScript>().hasItem = false; // set previous slot to empty
		equiped = true; // set equiped to true so that the object follows the mouse (update function)
		item.gameObject.transform.parent.gameObject.AddComponent<BoxCollider> (); // return the box collider to slot
		Vector3 cen = new Vector3 (0, 0, -3); // initialize new box collider position
		item.gameObject.transform.parent.gameObject.GetComponent<BoxCollider>().center = cen; // set new box collider position to in front
		}

	public static void swap(GameObject inventoryItem, GameObject currentItem) { // swap inventory items
		// set currently equiped item's parent to the slot of the item in inventory to swap with
		currentItem.gameObject.transform.parent = inventoryItem.gameObject.transform.parent;
		// also set the position of that item to the position of the slot
		currentItem.transform.position = inventoryItem.transform.position;
		// change the equiped item
		equipedItem = inventoryItem;
		// remove the collider on the new equiped item so that it can interact with other objects
		Destroy (equipedItem.collider);
		// add a box collider to the item just now placed in inventory
		currentItem.gameObject.AddComponent<BoxCollider> ();
		// initialize and set the position of the box collider (helps with layering)
		Vector3 pos = new Vector3 (0, 0, -5);
		currentItem.gameObject.GetComponent<BoxCollider> ().center = pos;
		}
}