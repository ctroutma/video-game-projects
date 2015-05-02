using UnityEngine;
using System.Collections;

public class lvl3Key : MonoBehaviour {

	public static bool inInventory = false;
	
	void OnMouseDown() {
		if (!inInventory) {
			// do stuff while item is in room
			iManager.AddToInventory (this.gameObject); // add the item to inventory
			inInventory = true; // note that this item is in the inventory
		}
		else if (inInventory) {
			// do stuff while item is in inventory
			if (iManager.equiped) { // if there is an item equiped already
				iManager.swap(this.gameObject, iManager.equipedItem); // swap the items
			}
			else {
				iManager.equipObject(this.gameObject); // if no item was already equiped, then equip the item clicked on
			}
		}
		
	}

	// Use this for initialization
	void Start () {
		inInventory = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
