using UnityEngine;
using System.Collections;
using InControl;


// Basic Elevator Control on Y axis using RightStick input

public class PlaneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Use last device which provided input.
		var inputDevice = InputManager.ActiveDevice;

		// raise and lower plane with right stick Y
		transform.Translate(0.0f, 10.0f * Time.deltaTime * inputDevice.RightStickY, 0.0f, Space.World);

		// lower plane with Z key
		bool zPressed = inputDevice.GetControl( InputControlType.Action1 );
		if(zPressed){
			transform.Translate(0.0f, -10.0f * Time.deltaTime, 0.0f, Space.World);
		}

		
		// raise plane with C key
		bool cPressed = inputDevice.GetControl( InputControlType.Action2 );
		if(cPressed){
			transform.Translate(0.0f, 10.0f * Time.deltaTime, 0.0f, Space.World);
		}
	}
}
