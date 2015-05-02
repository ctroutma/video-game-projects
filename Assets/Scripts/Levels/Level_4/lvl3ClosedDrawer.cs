using UnityEngine;
using System.Collections;

public class lvl3ClosedDrawer : MonoBehaviour {

	public GameObject openDrawerPreFab;
	public GameObject keyPreFab;
	Vector3 drawerPos = new Vector3(2.33f, 6.43f, 0f);
	Vector3 keyPos = new Vector3(2.62f, 6.83f, 0f);
	public static bool isOpen = false;


	void OnMouseDown() 
	{
		if (!isOpen) {
			if (!lvl3Key.inInventory) { // if the key has not been found
				GameObject key = Instantiate (keyPreFab) as GameObject; // create key
				key.transform.position = keyPos; // place key in correct place
			}

			GameObject openDrawer = Instantiate (openDrawerPreFab) as GameObject; // open the drawer
			openDrawer.transform.position = drawerPos; // place open drawer in correct place 
			isOpen = true;
		}
	}

	// Use this for initialization
	void Start () {
		lvl3Key.inInventory = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
