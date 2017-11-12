using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartGameButton : MonoBehaviour {

	public Button myButton;
	
	void Start()
	{
	
//		Button btn = myButton.GetComponent<Button>();
		
	}

//	void Update()
//	{
//		bool btn;
//		if (btn == true)
//		{
//			StartGame();
//		}
//	}

	public void StartGame()
	{
		SceneManager.LoadScene("2DMain");
	}
}
