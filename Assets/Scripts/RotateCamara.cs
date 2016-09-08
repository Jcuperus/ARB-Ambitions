using UnityEngine;
using System.Collections;

public class RotateCamara : MonoBehaviour {

	int rotateDirection = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		transform.rotation = new Quaternion ( 0f, 0f, 0f, 0f);
//		Debug.Log(transform.eulerAngles.z);


//		if(transform.eulerAngles.z < 0 && rotateDirection > 0)
//		{
//			rotateDirection = 1;
//		}else if(transform.eulerAngles.z > 180 && rotateDirection < 0)
//		{
//			rotateDirection = -1;
//		}
//		float test = Time.time - (Time.time/10);
//		transform.Rotate(new Vector3(0f,0f,1f * Mathf.Cos(test) ));
	}
}
