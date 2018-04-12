using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GUIText player1ScoreLabel, player2ScoreLabel;
	public static int player1Score, player2Score;
	public static string winner;

	

	public static void WallHit(bool leftWall) {
		if(leftWall) {
			player2Score++;
		} else {
			player1Score++;
		}

		if (player1Score == 5) {
				winner = "Joueur 1";
		}
		if (player2Score == 5) {
				winner = "Joueur 2";
		}
	}

	void OnGUI() {
		player1ScoreLabel.text = "<b>Joueur 1 :</b> " + player1Score;
		player2ScoreLabel.text = "<b>Joueur 2 :</b> " + player2Score;
	}
}
