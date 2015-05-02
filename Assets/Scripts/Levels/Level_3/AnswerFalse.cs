using UnityEngine;
using System.Collections;

public class AnswerFalse : MonoBehaviour {

	GameObject pic;
	public int waitTime;

	void OnMouseDown() {
		pic = GameObject.Find("Dark1"); // sorting order for first pic
		pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
		pic = GameObject.Find ("Dark2"); // sorting order for second pic
		pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
		pic = GameObject.Find ("Dark3"); // sorting order for third pic
		pic.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
		GameManager.level_3_complete = true;
		StartCoroutine (wait ());
	}


	IEnumerator wait ()
	{
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("LevelCompletion");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
