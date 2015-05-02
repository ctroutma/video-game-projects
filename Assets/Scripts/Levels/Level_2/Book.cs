using UnityEngine;
using System.Collections;

public class Book : MonoBehaviour {

	public GameObject openBook;
	public GameObject backArrow;

	void OnMouseDown ()
	{
		Instantiate (openBook);
		Instantiate (backArrow);
	}

}
