using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GUIText player1ScoreLabel, player2ScoreLabel, WinnerLabel;
	public static int player1Score, player2Score;

	public static void WallHit(bool leftWall) {
		if(leftWall) {
			player2Score++;
		} else {
			player1Score++;
		}
	}

	public static void Winner(string winner) {
		WinnerLabel.text = "<b>Vainqueur :</b> " + winner;
	}

	void OnGUI() {
		player1ScoreLabel.text = "<b>Joueur 1 :</b> " + player1Score;
		player2ScoreLabel.text = "<b>Joueur 2 :</b> " + player2Score;
	}
}
