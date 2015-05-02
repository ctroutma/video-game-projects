using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

	bool lightOn = true;
	GameObject pic, answer;

	void OnMouseDown() {
		if (lightOn) {
			// turn lights off
			lightOn = false;
			pic = GameObject.Find("Dark1"); // sorting order for first pic
			pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
			pic = GameObject.Find ("Dark2"); // sorting order for second pic
			pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
			answer = GameObject.Find ("AnswerFalse"); // get the answer choice
			answer.gameObject.AddComponent<BoxCollider>();
		}
		else if (!lightOn) {
			// turn lights on
			lightOn = true;
			pic = GameObject.Find("Dark1"); // sorting order for first pic
			pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
			pic = GameObject.Find ("Dark2"); // sorting order for second pic
			pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
			answer = GameObject.Find ("AnswerFalse"); // get the answer choice
			Destroy (answer.collider);
		}
	}

	// Use this for initialization
	void Start () {
		lightOn = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
