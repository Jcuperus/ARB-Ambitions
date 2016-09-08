using UnityEngine;
using System.Collections;

public class PlayerTriggers : MonoBehaviour {

	public bool hidden = false;

	void OnTriggerEnter2D (Collider2D col) {

		if(col.gameObject.name == "BoxForHiding")
		{
			hidden = true;
		}

		if(col.gameObject.name == "Camera" && !hidden) {
			// min leven?
			Debug.Log("spotted by cam");
			Main.lives--;
		}
	}

	void OnTriggerStay2D (Collider2D col) {
		

	}

	void OnTriggerExit2D(Collider2D col) {
		if(col.gameObject.name == "BoxForHiding")
		{
			hidden = false;
		}
	}

}
