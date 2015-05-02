using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public GameObject slotPreFab;
	public int numSlots = 8;
	public float slotStartX = -9f;
	public float slotStartY = .8f;
	public float slotSpacingX = 3f;
	public float slotSpacingY = 2.25f;
	public static List<GameObject> slotList;


	// Use this for initialization
	void Start () { // adding slots to inventory system
		GameObject inventory = GameObject.FindWithTag ("Inventory");
		slotList = new List<GameObject> ();
		for (int i=0; i< 4; i++) {
			GameObject slotGO = Instantiate (slotPreFab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = slotStartY;
			pos.x = slotStartX + (slotSpacingX * i);
			slotGO.transform.position = pos;
			slotGO.transform.parent = inventory.transform;
			Vector3 cen = new Vector3 (0, 0, -3); // initialize new box collider position
			slotGO.gameObject.GetComponent<BoxCollider>().center = cen; // set new box collider position to in front
			//slotGO.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "inventory background";
			slotList.Add (slotGO);
				}
		for (int i=0; i<4; i++) {
			GameObject slotGO = Instantiate (slotPreFab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = slotStartY - slotSpacingY;
			pos.x = slotStartX + (slotSpacingX * i);
			slotGO.transform.position = pos;
			slotGO.transform.parent = inventory.transform;
			Vector3 cen = new Vector3 (0, 0, -3); // initialize new box collider position
			slotGO.gameObject.GetComponent<BoxCollider>().center = cen; // set new box collider position to in front
			//slotGO.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "inventory background";
			slotList.Add (slotGO);
				}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
