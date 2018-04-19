using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class PositionTrackerController : MonoBehaviour
{
    public GameObject PositionDisplay;
    public GameObject PlayerCar;
    public GameObject PlayerPositionTriggers;
    public GameObject RaceFinishTrigger;
    public GameObject[] AICar;
    public int PlayerPosition;
    public bool isFinished;

	// Use this for initialization
	void Start ()
    {
        PlayerCar = GameObject.FindGameObjectsWithTag("Player")[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!isFinished)
        {
            PlayerPosition = 1;

            for (int i = 0; i < AICar.Length; i++)
            {
                if (AICar[i] != null)
                {
                    if (PlayerPositionTriggers.gameObject.transform.Find("LapCompleteTrigger").gameObject.GetComponent<LapComplete>().LapsCompleted
                    < AICar[i].GetComponent<PositionTriggersAI>().CurrentLap)
                    {
                        PlayerPosition += 1;
                    }

                    else if (PlayerPositionTriggers.gameObject.transform.Find("LapCompleteTrigger").gameObject.GetComponent<LapComplete>().LapsCompleted == AICar[i].GetComponent<PositionTriggersAI>().CurrentLap
                         && PlayerPositionTriggers.gameObject.transform.Find("PlayerTracker").gameObject.GetComponent<AICarTrack>().waypointCount
                         < AICar[i].GetComponent<CarAIControl>().GetTarget().gameObject.GetComponent<AICarTrack>().waypointCount)
                    {
                        PlayerPosition += 1;
                    }

                    else if (PlayerPositionTriggers.gameObject.transform.Find("LapCompleteTrigger").gameObject.GetComponent<LapComplete>().LapsCompleted == AICar[i].GetComponent<PositionTriggersAI>().CurrentLap
                         && PlayerPositionTriggers.gameObject.transform.Find("PlayerTracker").gameObject.GetComponent<AICarTrack>().waypointCount
                         == AICar[i].GetComponent<CarAIControl>().GetTarget().gameObject.GetComponent<AICarTrack>().waypointCount

                         && Vector3.Distance(PlayerCar.transform.position, PlayerPositionTriggers.gameObject.transform.Find("PlayerTracker").transform.position)
                         > Vector3.Distance(AICar[i].transform.position, AICar[i].GetComponent<CarAIControl>().GetTarget().transform.position))
                    {
                        PlayerPosition += 1;
                    }
                }
            }
        }

        PositionDisplay.GetComponent<Text>().text = "0" + PlayerPosition;
    }
}
