using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCameraController : MonoBehaviour
{
	void Update ()
    {
        this.transform.Rotate(0, 1, 0, Space.World);
	}
}
