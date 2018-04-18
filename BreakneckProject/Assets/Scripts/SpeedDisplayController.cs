using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class SpeedDisplayController : MonoBehaviour {

    public GameObject SpeedDisplay;
    public GameObject Player;
    public int CurrentSpeed;

	// Use this for initialization
	void Start ()
    {
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
        CurrentSpeed = (int)Player.GetComponent<CarController>().CurrentSpeed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        SpeedDisplay.GetComponent<Text>().text = "MPH: " + CurrentSpeed;
	}
}
