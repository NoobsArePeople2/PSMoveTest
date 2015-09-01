using UnityEngine;
using System.Collections;

public class PSNavTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (Input.GetJoystickNames ().Length + " joysticks connected.");
		foreach (string name in Input.GetJoystickNames()) {
			Debug.Log ("JS: " + name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetAxis ("Horizontal") != 0.0f) {
			Debug.Log ("X: " + Input.GetAxis ("Horizontal"));
		}

		if (Input.GetAxis ("Vertical") != 0.0f) {
			Debug.Log ("Y: " + Input.GetAxis ("Vertical"));
		}

	}
}
