using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinishController : MonoBehaviour
{
    private GameObject Player;
    private GameObject FinishCam;
    private GameObject ViewModes;
    private GameObject LevelMusic;
    private GameObject CompleteTrigger;
    private GameObject PositionTracker;
    public AudioSource finishMusic;

    private void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
        FinishCam = Player.gameObject.transform.Find("VictoryCameraFocusPoint").gameObject;
        ViewModes = Player.gameObject.transform.Find("Cameras").gameObject;
        LevelMusic = GameObject.Find("Music");
        CompleteTrigger = GameObject.Find("RaceFinishTrigger");
        PositionTracker = GameObject.Find("PositionTracker");
        print(Player);
        print(FinishCam);
        print(ViewModes);
        print(LevelMusic);
        print(CompleteTrigger);
        //finishMusic = AudioSource.
    }
    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Player.SetActive(false);
        //Player.GetComponent<CarController>().CurrentSpeed = 0.0f;
        Player.GetComponent<CarController>().enabled = false;
        Player.GetComponent<CarUserControl>().enabled = false;
        Player.GetComponent<CarAudio>().Mute();
        Player.SetActive(true);
        FinishCam.SetActive(true);
        LevelMusic.SetActive(false);
        ViewModes.SetActive(false);
        PositionTracker.GetComponent<PositionTrackerController>().isFinished = true;
        finishMusic.Play();
        CompleteTrigger.SetActive(false);
    }
}
