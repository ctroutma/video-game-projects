using UnityEngine;
using System.Collections;

public class Level_5_Page : MonoBehaviour {

	public static bool inInventory = false;
	
	void OnMouseDown() {
		if (!inInventory) {
			// do stuff while item is in room
			iManager.AddToInventory (this.gameObject); // add the item to inventory
			inInventory = true; // note that this item is in the inventory
		}
		else if (inInventory) {
			// do stuff while item is in inventory
			GameObject pic = GameObject.Find ("Room_5_Page_Read");
			pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 60;
			pic.gameObject.AddComponent<BoxCollider>();
			GameObject pic1 = GameObject.Find ("PageBack");
			pic1.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 61;
			pic1.gameObject.AddComponent<BoxCollider>();
			pic1.gameObject.GetComponent<BoxCollider>().center = new Vector3(0,0,-6);

			Inventory_button.closeInventory (); // close the inventory on page in inventory
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
