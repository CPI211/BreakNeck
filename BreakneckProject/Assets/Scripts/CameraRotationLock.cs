using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationLock : MonoBehaviour
{

    [SerializeField] Transform target;
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
        transform.Rotate(-20, 0, 0);
    }
}
