using UnityEngine;
using System.Collections;

public class StealthCamera : MonoBehaviour {

	public float interval = 10f;
	public bool camaraActive = true;
	public GameObject indicatorLight;

	private float timer = 0f;
	// Use this for initialization
	void Start () {
//		interval = 2f;
	}
	
	// Update is called once per frame
	void Update () {

		if (timer > interval) {
			Debug.Log (timer + " "+ interval);
			camaraActive = !camaraActive;
			ToggleCam (camaraActive);
			timer = 0f;
			indicatorLight.SetActive (camaraActive);
		}

		if (timer > interval - 1) {
		
			indicatorLight.SetActive (true);
		}

		timer += Time.deltaTime;

	}

	private void ToggleCam (bool v) {
//		Debug.Log (v);
		GetComponent<Collider2D> ().enabled = v;
		GetComponent<SpriteRenderer> ().enabled = v;
	}

//	void OnCollisionEnter2D (Collision2D col) {
//		Debug.Log("Cam spotted playe11r!");
//		if(col.gameObject.name == "Player") {
//			// min leven?
//			Debug.Log("Cam spotted player!");
//		}
//	}
}
