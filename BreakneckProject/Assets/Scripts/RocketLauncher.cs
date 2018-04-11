using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour {

	public Rigidbody rocket;

	public Transform startSide;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			Rigidbody rocketInstant;
			rocketInstant = Instantiate (rocket, startSide.position, startSide.rotation) as Rigidbody;
			rocketInstant.AddForce (startSide.forward * 5000);
		}
		//Destroy (rocket, 3.0f);
	}
}
