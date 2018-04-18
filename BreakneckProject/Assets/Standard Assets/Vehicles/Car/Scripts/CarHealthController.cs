using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealthController : MonoBehaviour
{
    public int MaxHealth;
    private int CurrentHealth;

	// Use this for initialization
	void Start ()
    {
        CurrentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
