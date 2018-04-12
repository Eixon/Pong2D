using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

		public void GoToMainScene() {
				GameManager.player1Score = 0;
				GameManager.player2Score = 0;
				SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
		}

		public void ReturnToMenu() {
				SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
		}
}
