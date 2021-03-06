﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public GameObject TotalLapCounter;

    public int LapsCompleted;
    public int LapsTotal;

    public GameObject RaceFinish;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollider"))
        {
            print("Hello?");
            if (isBestTime() && LapsCompleted != 0)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
                }

                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
            }
            
            if (isBestTime() && LapsCompleted != 0)
            {
                PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
                PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
                PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
            }

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;

            LapsCompleted += 1;

            if (LapsCompleted <= LapsTotal)
            {
                if (LapsCompleted < 10) { LapCounter.GetComponent<Text>().text = "0" + LapsCompleted; }
                else { LapCounter.GetComponent<Text>().text = "" + LapsCompleted; }

                if (LapsCompleted < 10) { TotalLapCounter.GetComponent<Text>().text = "/ 0" + LapsTotal;  }
                else { TotalLapCounter.GetComponent<Text>().text = "/ " + LapsTotal; }
            }

            if (LapsCompleted > LapsTotal) { RaceFinish.SetActive(true); }
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }

    }

    private bool isBestTime()
    {
        if (LapTimeManager.MinuteCount < PlayerPrefs.GetInt("MinSave"))
        { return true; }

        else if (LapTimeManager.MinuteCount == PlayerPrefs.GetInt("MinSave") &&
                LapTimeManager.SecondCount < PlayerPrefs.GetInt("SecSave"))
        { return true; }

        else if (LapTimeManager.MinuteCount == PlayerPrefs.GetInt("MinSave") &&
                LapTimeManager.SecondCount == PlayerPrefs.GetInt("SecSave") &&
                LapTimeManager.MilliCount < PlayerPrefs.GetFloat("MilliSave"))
        { return true; }

        else { return false; }
    }

}
