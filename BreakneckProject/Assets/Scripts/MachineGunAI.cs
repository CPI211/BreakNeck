using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunAI : MonoBehaviour
{
    public Rigidbody rocket;

    public Transform startSide;

    public GameObject MachineGun;
    private GameObject Player;
    private GameObject[] AICar;
    private RaycastHit objectHit;


    private bool canShoot;
    private float timer;
    public float shotDelay;
    public float LineOfSight;

    private void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
        AICar = GameObject.FindGameObjectsWithTag("AICar");

        canShoot = true;
    }

    private void Update()
    {
        Vector3 fwd = MachineGun.transform.TransformDirection(Vector3.up);
        Debug.DrawRay(MachineGun.transform.position, fwd * LineOfSight, Color.blue);
        if (Physics.SphereCast(MachineGun.transform.position, 4.0f, fwd, out objectHit, LineOfSight))
        {
            if (canShoot && (objectHit.transform.tag == "Player" || objectHit.transform.tag == "AICar"))
            {
                canShoot = false;

                Rigidbody rocketInstant;
                rocketInstant = Instantiate(rocket, startSide.position, startSide.rotation) as Rigidbody;
                rocketInstant.AddForce(startSide.up * 5000);
            }
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
