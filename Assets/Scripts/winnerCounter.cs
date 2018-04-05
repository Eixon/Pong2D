using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winnerCounter : MonoBehaviour {
	public static string winner;
	public GUIText endLabel;
	
	// Update is called once per frame
	void Update () {
		if(SceneManager.GetActiveScene().name == "EndScene") endLabel.text = "Vainqueur : " + winner;
	}
}
