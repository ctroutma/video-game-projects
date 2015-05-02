using UnityEngine;
using System.Collections;

public class lvl3OpenDrawer : MonoBehaviour {




	void OnMouseDown()
	{
		if (!lvl3Key.inInventory) {
						GameObject key = GameObject.FindWithTag ("key");
						Destroy (key);
				}

		lvl3ClosedDrawer.isOpen = false;
		Destroy (this.gameObject);


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
