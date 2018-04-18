using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunController : MonoBehaviour {

	public Rigidbody rocket;

    public Transform startSide;

    private bool canShoot;
    private float timer;
    public float shotDelay = 0.3f;

    private void Start()
    {
        canShoot = true;
    }

    void Update () 
	{
        if ((Input.GetAxis("Fire1") > 0) && (canShoot))
        {
            canShoot = false;

			Rigidbody rocketInstant;
			rocketInstant = Instantiate (rocket, startSide.position, startSide.rotation) as Rigidbody;
			rocketInstant.AddForce (startSide.up * 5000);
		}

        if (!canShoot)
        {
            timer += Time.deltaTime; //Time.deltaTime is the amount of time between FPS
            if (timer >= shotDelay)
            {
                canShoot = true;
                timer = 0f;
            }
        }
    }
}
