using UnityEngine;
using System.Collections;

public class Level_5_Remove_Page : MonoBehaviour {

	void OnMouseDown() {
		this.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		GameObject pic = GameObject.Find ("Room_5_Page_Read");
		pic.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		Destroy (pic.gameObject.collider);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
