using UnityEngine;
using System.Collections;

public class Level_5_Read_Page : MonoBehaviour {

	float difX;
	float difY;

	void OnMouseDown() {
		Vector3 mousePos2D = Input.mousePosition;	// 1
		
		// The Camera's z position sets how far to push the mouse into 3D
		mousePos2D.z = -Camera.main.transform.position.z;	// 2
		
		// Convert the point from 2D screen space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);	// 3
		
		difX = mousePos3D.x - this.gameObject.transform.position.x;
		difY = mousePos3D.y - this.gameObject.transform.position.y;

	}


	void OnMouseDrag() {
		// Get the current screen position of the mouse from Input
		Vector3 mousePos2D = Input.mousePosition;	// 1
		
		// The Camera's z position sets how far to push the mouse into 3D
		mousePos2D.z = -Camera.main.transform.position.z;	// 2
		
		// Convert the point from 2D screen space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);	// 3

		// Move the x position of this Basket to the x position of the Mouse
		
		Vector3 pos = this.gameObject.transform.position;
		pos.x = mousePos3D.x - difX;
		pos.y = mousePos3D.y - difY;
		this.gameObject.transform.position = pos;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
