using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTriggerAI : MonoBehaviour
{
    public GameObject[] AICar;

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < AICar.Length; i++)
        {
            if (AICar[i] != null && other.gameObject.transform.parent.parent.gameObject == AICar[i])
            {
                if (AICar[i].GetComponent<PositionTriggersAI>().HalfPointTrigger == true)
                {
                    AICar[i].GetComponent<PositionTriggersAI>().HalfPointTrigger = false;
                    AICar[i].GetComponent<PositionTriggersAI>().LapCompleteTrigger = true;
                }
            }
        }
    }


}
