using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	public Button resetButton;
	
	// Use this for initialization
	void Start () {
		Button btn = resetButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick()
	{
		SceneManager.LoadScene ("MainScene");
	}


}
