using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimationController : MonoBehaviour
{
    public GameObject CarModel;
    public float OriginalRotation;
    public float x;
    public float y;
    public float z;

    private void Start()
    {
        x = CarModel.transform.rotation.x;
        y = CarModel.transform.rotation.y;
        z = CarModel.transform.rotation.z;
    }
    // Update is called once per frame
    void Update ()
    {
        print(CarModel.transform.localEulerAngles.x);
        print(CarModel.transform.localEulerAngles.y);
        print(CarModel.transform.localEulerAngles.z);
        //print(OriginalRotation + 0.1f);
        //print(OriginalRotation - 0.1f);

        if ((Input.GetAxis("Horizontal") > 0))// && CarModel.gameObject.transform.rotation.z <= OriginalRotation + 0.1f)
        {
            CarModel.transform.Rotate(0, 1, 0);
        }

        else if ((Input.GetAxis("Horizontal") < 0))// && CarModel.gameObject.transform.rotation.z >= OriginalRotation - 0.1f)
        {
            CarModel.transform.Rotate(0, 1, 0);
        }
        
        else if (CarModel.gameObject.transform.rotation.y != gameObject.transform.parent.gameObject.transform.rotation.y)
        {
            CarModel.transform.rotation = gameObject.transform.parent.gameObject.transform.rotation;
        }
    }
}
