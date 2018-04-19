using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTriggerPosition : MonoBehaviour
{
    private float x;
    private float y;
    private float z;
    private float xr;
    private float yr;
    private float zr;

	// Use this for initialization
	void Start ()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        xr = this.transform.rotation.x;
        yr = this.transform.rotation.y;
        zr = this.transform.rotation.z;
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = new Vector3(x, y, z);
        this.transform.rotation = new Quaternion(xr, yr, zr, 1);
    }
}
