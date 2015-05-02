using UnityEngine;
using System.Collections;

public class slotScript : MonoBehaviour {

	public bool hasItem = false;

	void OnMouseDown() {
		if (iManager.equiped && !this.gameObject.GetComponent<slotScript> ().hasItem) { // if slot doesn't have object, the place object in slot
			iManager.equipedItem.gameObject.AddComponent<BoxCollider>(); // add box collider back to the object
			Vector3 pos = new Vector3 (0, 0, -5); // initialize new box collider position
			iManager.equipedItem.gameObject.GetComponent<BoxCollider>().center = pos; // set new box collider position to in front
			Destroy(this.collider); // remove the slot collider (interferes with clicking object in inventory
			iManager.equiped = false; // player no longer has item equiped
			iManager.equipedItem.transform.parent = this.gameObject.transform; // set the parent of object to the new slot
			iManager.equipedItem.transform.position = this.gameObject.transform.position; // set position of parent to object
			this.gameObject.GetComponent<slotScript>().hasItem = true; // set the slot hasItem to true
				}
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
