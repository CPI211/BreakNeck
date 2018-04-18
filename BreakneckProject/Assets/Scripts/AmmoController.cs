using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    public int damage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "AICar" || other.gameObject.tag == "Terrain")
        {
            print("Hit.");
            GameObject.Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "AICar")
        {
            other.gameObject.GetComponent<CarHealthController>().DealDamage(damage);
        }
    }
}
