using UnityEngine;
using System.Collections;

public class Inventory_button : MonoBehaviour {

	public static bool Iup = false;

	void OnMouseDown()
	{
		if (Iup) {
			closeInventory();
		}
		else {
			openInventory();
		}
	}

	public static void openInventory() {
		GameObject inventory = GameObject.FindWithTag ("Inventory");
		Vector3 pos;
		pos = inventory.transform.position;
		pos.y = 5.3f; // just for this lvl
		inventory.transform.position = pos;
		Iup = true;
	}

	public static void closeInventory() {
		GameObject inventory = GameObject.FindWithTag ("Inventory");
		Vector3 pos;
		pos = inventory.transform.position;
		pos.y = 0f; // just for this lvl
		inventory.transform.position = pos;
		Iup = false;
	}

}
