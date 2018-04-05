using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class BallControl : MonoBehaviour {
	public float speed;
	public float spreadAngle;
	
	void Start () {
		Reset();
	}

	void Reset() {
		float angle = 0f;
		transform.position = Vector2.zero;
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;

		Vector2 unitDirection = new Vector2(
			Mathf.Cos(Mathf.Deg2Rad * angle),
			Mathf.Sin(Mathf.Deg2Rad * angle));
				
		Vector2 direction = unitDirection * speed;

		if(Random.Range(0f, 1f) < 0.5) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-direction.x, direction.y));
		} else {
			GetComponent<Rigidbody2D>().AddForce(direction);
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.collider.tag == "Player") {
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			Vector3 randomDirection = new Vector3(Random.Range(-50, 50), Random.Range(-5, -5), 0);
			GetComponent<Rigidbody2D>().AddForce(randomDirection.normalized * speed, ForceMode2D.Force);
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.tag == "SideWall") {
			if (GameManager.player1Score == 5 || GameManager.player2Score == 5)
					SceneManager.LoadScene ("EndScene");
			else Reset();
		}
	}
}
