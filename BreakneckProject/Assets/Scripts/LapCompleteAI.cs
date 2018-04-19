using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteAI : MonoBehaviour
{

    public GameObject LapCounter;
    public GameObject[] AICar;

    void Update()
    {
        print(AICar[0].GetComponent<PositionTriggersAI>().currentLap);
    }

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < AICar.Length; i++)
        {
            if (AICar[i] != null && other.gameObject.transform.parent.parent.gameObject == AICar[i])
            {
                if (AICar[i].GetComponent<PositionTriggersAI>().lapCompleteTrigger == true)
                {
                    AICar[i].GetComponent<PositionTriggersAI>().currentLap += 1;
                    //LapCounter.GetComponent<Text>().text = "0" + AICar[i].GetComponent<PositionTriggersAI>().currentLap;
                    AICar[i].GetComponent<PositionTriggersAI>().lapCompleteTrigger = false;
                    AICar[i].GetComponent<PositionTriggersAI>().halfPointTrigger = true;
                }
            }
        }
    }


}
