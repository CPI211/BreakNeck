using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTrack : MonoBehaviour
{

    public GameObject tracker;
    public GameObject AICar;
    public GameObject[] waypoint = new GameObject[34];
    public int waypointCount;

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < waypoint.Length; i++)
        {
            if (waypointCount == i)
            {
                tracker.transform.position = waypoint[i].transform.position;
                tracker.transform.rotation = waypoint[i].transform.rotation;
                tracker.transform.localScale = waypoint[i].transform.localScale;
            }
        }

        /*if (Vector3.Distance(transform.position, AICar.transform.position) < 30)
        {
            print(waypoint);

            GetComponent<BoxCollider>().enabled = false;

            waypointCount++;
            if (waypointCount == waypoint.Length) { waypointCount = 0; }

            //yield return new WaitForSeconds(1);

            GetComponent<BoxCollider>().enabled = true;
        }*/
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        print(other.gameObject.transform.parent.parent.name);
        print(AICar.name);

        if (other.gameObject.transform.parent.parent.name == AICar.name)
        {
            print(waypoint);

            GetComponent<BoxCollider>().enabled = false;

            waypointCount++;
            if (waypointCount == waypoint.Length) { waypointCount = 0; }

            yield return new WaitForSeconds(0);

            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
