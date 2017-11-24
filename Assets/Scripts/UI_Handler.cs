using UnityEngine;
using System.Collections;

public class UI_Handler : MonoBehaviour {

	public int mainMenuScene;
	public int sceneLevel;
	public int sceneHelp;
	public int sceneCredit;
	public int sceneLevelSelect;

	public void MainMenu() {
		Application.LoadLevel (mainMenuScene);
	}

	public void Play() {
		Application.LoadLevel (sceneLevel);
	}

	public void SelectLevel() {
		Application.LoadLevel (sceneLevelSelect);
	}

	public void loadSpecificLevel(int levelNumber) {
		Application.LoadLevel (levelNumber);
	}

	public void Help() {
		Application.LoadLevel (sceneHelp);
	}

	public void Credits() {
		Application.LoadLevel (sceneCredit);
	}

	public void RestartLevel() {
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Quit() {
		Application.Quit ();
	}
}
