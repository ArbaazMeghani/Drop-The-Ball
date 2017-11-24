using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int scoreValue;
	public int numberOfThrows;
	public int nextLevel;
	public PlayerController playerController;
	public Canvas menu;
	public Canvas gameOverMenu;

	public Text scoreText;
	public Text throwsLeftText;
	public Button nextButton;
	public Text gameOverText;

	private int currentScore = 0;
	private int remainingPickups = 5;

	// Use this for initialization
	void Start () {
		gameOverMenu.enabled = false;
		menu.enabled = false;
		numberOfThrows++;
		UpdateThrows ();
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(menu.enabled == true)
				CloseMenu();
			else
				OpenMenu();
		}

		if (remainingPickups <= 0 || numberOfThrows <= 0) {
			playerController.enabled = false;
			if(GameObject.FindGameObjectsWithTag("Projectile").Length <= 0)
				GameOver();
		}
	}

	void OpenMenu() {
		playerController.enabled = false;
		menu.enabled = true;
	}

	void CloseMenu() {
		menu.enabled = false;
		playerController.enabled = true;
	}

	void GameOver() {
		menu.enabled = false;
		menu.gameObject.SetActive (false);
		gameOverMenu.enabled = true;
		if (remainingPickups > 0)
			LoseGame ();
		else
			WinGame ();
	}

	void LoseGame() {
		gameOverText.text = "You Lose";
		nextButton.gameObject.SetActive (false);
	}

	void WinGame() {
		gameOverText.text = "You Win";
		nextButton.gameObject.SetActive (true);
	}

	public void UpdateThrows() {
		numberOfThrows--;
		throwsLeftText.text = "Throws Remaining: " + numberOfThrows.ToString ();
	}

	public void AddScore() {
		remainingPickups--;
		currentScore += scoreValue;
		scoreText.text = "Score: " + currentScore.ToString ();
	}
}
