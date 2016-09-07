using UnityEngine;
using System.Collections;

public class StealthCamera : MonoBehaviour {

	public Vector3[] newVertices;
	public Vector2[] newUV;
	public int[] newTriangles;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "player")
		{
			// min leven?
		}
	}
}
