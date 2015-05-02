using UnityEngine;
using System.Collections;

public class buttonController : MonoBehaviour {




	public void toNextLevel ()
	{
		if (!GameManager.level_1_complete) {
			Application.LoadLevel("Level_1");
		}
		else if (!GameManager.level_2_complete) {
			Application.LoadLevel("Level_2");
		}
		else if (!GameManager.level_3_complete) {
			Application.LoadLevel("Level_3");
		}
		else if (!GameManager.level_4_complete) {
			Application.LoadLevel("Level_4");
		}
		else if (!GameManager.level_5_complete) {
			Application.LoadLevel("Level_5");
		}
		else {
			Application.LoadLevel("TitleScene");
		}
	}

	public void toMainMenu ()
	{
		Application.LoadLevel ("TitleScene");
	}

	public void toLevelSelect ()
	{
		Application.LoadLevel ("LevelSelect");
	}

	public void toLevel_1()
	{
		Application.LoadLevel ("Level_1");
	}

	public void toLevel_2 ()
	{
		Application.LoadLevel ("Level_2");
	}

	public void toLevel_3 ()
	{
		Application.LoadLevel ("Level_3");
	}

	public void toLevel_4 ()
	{
		Application.LoadLevel ("Level_4");
	}

	public void toLevel_5 ()
	{
		Application.LoadLevel ("Level_5");
	}

	public void toCredits()
	{
		Application.LoadLevel ("Credits");
	}


}
