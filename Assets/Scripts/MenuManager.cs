using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public Canvas startCanvas;
	public Canvas gameOverCanvas;
	public Canvas victoryCanvas;
	public Canvas ingameCanvas;

	public Text livesValueText;
	// Use this for initialization
	void Start () {

		SetScreen (0);
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void SetScreen (int v) {

		DisplayStartScreen (false);
		DisplayInGameGUI (false);
		DisplayGameOverScreen (false);
		DisplayVictoryScreen (false);

		if (v == 0) {
			DisplayStartScreen (true);
		}

		if (v == 1) {
			DisplayGameOverScreen (true);
		}

		if (v == 2) {
			DisplayVictoryScreen (true);
		}

		if (v == 3) {
			DisplayInGameGUI (true);
		}

	}

	private void DisplayStartScreen (bool v) {

		// show
		if (v) {
			startCanvas.gameObject.SetActive (true);
			return;
		}

		// hide
		startCanvas.gameObject.SetActive (false);
	}

	private void DisplayGameOverScreen (bool v) {

		// show
		if (v) {
			gameOverCanvas.gameObject.SetActive (true);
			return;
		}

		// hide
		gameOverCanvas.gameObject.SetActive (false);
	}

	private void DisplayVictoryScreen (bool v) {

		// show
		if (v) {
			victoryCanvas.gameObject.SetActive (true);
			return;
		}

		// hide
		victoryCanvas.gameObject.SetActive (false);
	}

	private void DisplayInGameGUI (bool v) {

		// show
		if (v) {
			Main.InitGame ();
			livesValueText.text = Main.lives.ToString();
			ingameCanvas.gameObject.SetActive (true);
			return;
		}

		// hide
		ingameCanvas.gameObject.SetActive (false);
	}
}
