using UnityEngine;
using System.Collections;

public class BackArrow : MonoBehaviour {

	void OnMouseDown ()
	{
		Destroy (gameObject);
		GameObject openBook = GameObject.FindWithTag ("OpenBook");
		Destroy (openBook);
	}
}
