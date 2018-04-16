using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject FPCamera;
    public GameObject NormalCamera;
    public GameObject FarCamera;
    public GameObject Player;
    public int cameraMode;

    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
        FPCamera = Player.transform.Find("Cameras").transform.Find("FPCamera").gameObject;
        NormalCamera = Player.transform.Find("Cameras").transform.Find("NormalCamera").gameObject;
        FarCamera = Player.transform.Find("Cameras").transform.Find("FarCamera").gameObject;
        FPCamera.SetActive(false);
        NormalCamera.SetActive(true);
        FarCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("ViewMode"))
        {
            if (cameraMode == 2) { cameraMode = 0; }
            else { cameraMode++; }

            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);

        if (cameraMode == 0)
        {
            FPCamera.SetActive(true);
            NormalCamera.SetActive(false);
            FarCamera.SetActive(false);
        }

        else if (cameraMode == 1)
        {
            NormalCamera.SetActive(true);
            FarCamera.SetActive(false);
            FPCamera.SetActive(false);
        }

        else if (cameraMode == 2)
        {
            FPCamera.SetActive(false);
            NormalCamera.SetActive(false);
            FarCamera.SetActive(true);
        }
    }
}
