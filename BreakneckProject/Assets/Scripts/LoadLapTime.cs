using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    // Use this for initialization
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");

        if (MinCount >= 10) { MinDisplay.GetComponent<Text>().text = "" + MinCount + ":"; }
        else { MinDisplay.GetComponent<Text>().text = "0" + MinCount + ":"; }
        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;

    }
}
