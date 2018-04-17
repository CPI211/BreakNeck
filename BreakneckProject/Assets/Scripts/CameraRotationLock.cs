using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationLock : MonoBehaviour
{

    [SerializeField] Transform target;
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 xRotation = new Vector3(-20, 0, 0);
        Quaternion toRotate = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
        transform.rotation = toRotate;
        transform.Rotate(xRotation);

        //if (transform.position.y < 0.1f) { transform.position = new Vector3(transform.position.x, 0.11f, transform.position.z); }
    }

    IEnumerator cameraRotate()
    {
        yield return new WaitForSeconds(0);
    }
}
