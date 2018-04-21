using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinishController : MonoBehaviour
{
    private GameObject Player;
    private GameObject[] AICar;
    private GameObject FinishCam;
    private GameObject ViewModes;
    private GameObject LevelMusic;
    private GameObject CompleteTrigger;
    private GameObject PositionTracker;
    public AudioSource finishMusic;

    private void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
        AICar = GameObject.FindGameObjectsWithTag("AICar");
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
        for (int i=0; i<AICar.Length;i++) { AICar[i].SetActive(false); }
        Player.GetComponent<CarController>().enabled = false;
        Player.GetComponent<CarUserControl>().enabled = false;
        Player.GetComponent<MachineGunController>().enabled = false;
        Player.GetComponent<CarAudio>().Mute();

        for (int i = 0; i < AICar.Length; i++)
        {
            AICar[i].GetComponent<CarController>().enabled = false;
            AICar[i].GetComponent<MachineGunAI>().enabled = false;
            AICar[i].GetComponent<CarAIControl>().enabled = false;
        }

        LevelMusic.SetActive(false);
        finishMusic.Play();

        Player.SetActive(true);
        for (int i = 0; i < AICar.Length; i++) { AICar[i].SetActive(true); }

        FinishCam.SetActive(true);
        ViewModes.SetActive(false);
        PositionTracker.GetComponent<PositionTrackerController>().isFinished = true;
        CompleteTrigger.SetActive(false);
    }
}
