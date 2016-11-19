using UnityEngine;
using System.Collections;

public class CapMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("Shoot!");
			GetComponent<Rigidbody>().AddForce (new Vector3 (0, 1, 1) * 200.0f);
		}	
	}
}
