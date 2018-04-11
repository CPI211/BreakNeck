using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTrack : MonoBehaviour
{

    public GameObject tracker;
    public GameObject waypoint01;
    public GameObject waypoint02;
    public GameObject waypoint03;
    public GameObject waypoint04;
    public GameObject waypoint05;
    public GameObject waypoint06;
    public GameObject waypoint07;
    public GameObject waypoint08;
    public GameObject waypoint09;
    public GameObject waypoint10;
    public GameObject waypoint11;
    public GameObject waypoint12;
    public GameObject waypoint13;
    public GameObject waypoint14;
    public GameObject waypoint15;
    public GameObject waypoint16;
    public GameObject waypoint17;
    public GameObject waypoint18;
    public GameObject waypoint19;
    public GameObject waypoint20;
    public GameObject waypoint21;
    public GameObject waypoint22;
    public GameObject waypoint23;
    public GameObject waypoint24;
    public GameObject waypoint25;
    public GameObject waypoint26;
    public GameObject waypoint27;
    public GameObject waypoint28;
    public GameObject waypoint29;
    public GameObject waypoint30;
    public GameObject waypoint31;
    public GameObject waypoint32;
    public GameObject waypoint33;
    public GameObject waypoint34;
    public int waypoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (waypoint == 0) { tracker.transform.position = waypoint01.transform.position; }
        else if (waypoint == 1) { tracker.transform.position = waypoint02.transform.position; }
        else if (waypoint == 2) { tracker.transform.position = waypoint03.transform.position; }
        else if (waypoint == 3) { tracker.transform.position = waypoint04.transform.position; }
        else if (waypoint == 4) { tracker.transform.position = waypoint05.transform.position; }
        else if (waypoint == 5) { tracker.transform.position = waypoint06.transform.position; }
        else if (waypoint == 6) { tracker.transform.position = waypoint07.transform.position; }
        else if (waypoint == 7) { tracker.transform.position = waypoint08.transform.position; }
        else if (waypoint == 8) { tracker.transform.position = waypoint09.transform.position; }
        else if (waypoint == 9) { tracker.transform.position = waypoint10.transform.position; }
        else if (waypoint == 10) { tracker.transform.position = waypoint11.transform.position; }
        else if (waypoint == 11) { tracker.transform.position = waypoint12.transform.position; }
        else if (waypoint == 12) { tracker.transform.position = waypoint13.transform.position; }
        else if (waypoint == 13) { tracker.transform.position = waypoint14.transform.position; }
        else if (waypoint == 14) { tracker.transform.position = waypoint15.transform.position; }
        else if (waypoint == 15) { tracker.transform.position = waypoint16.transform.position; }
        else if (waypoint == 16) { tracker.transform.position = waypoint17.transform.position; }
        else if (waypoint == 17) { tracker.transform.position = waypoint18.transform.position; }
        else if (waypoint == 18) { tracker.transform.position = waypoint19.transform.position; }
        else if (waypoint == 19) { tracker.transform.position = waypoint20.transform.position; }
        else if (waypoint == 20) { tracker.transform.position = waypoint21.transform.position; }
        else if (waypoint == 21) { tracker.transform.position = waypoint22.transform.position; }
        else if (waypoint == 22) { tracker.transform.position = waypoint23.transform.position; }
        else if (waypoint == 23) { tracker.transform.position = waypoint24.transform.position; }
        else if (waypoint == 24) { tracker.transform.position = waypoint25.transform.position; }
        else if (waypoint == 25) { tracker.transform.position = waypoint26.transform.position; }
        else if (waypoint == 26) { tracker.transform.position = waypoint27.transform.position; }
        else if (waypoint == 27) { tracker.transform.position = waypoint28.transform.position; }
        else if (waypoint == 28) { tracker.transform.position = waypoint29.transform.position; }
        else if (waypoint == 29) { tracker.transform.position = waypoint30.transform.position; }
        else if (waypoint == 30) { tracker.transform.position = waypoint31.transform.position; }
        else if (waypoint == 31) { tracker.transform.position = waypoint32.transform.position; }
        else if (waypoint == 32) { tracker.transform.position = waypoint33.transform.position; }
        else if (waypoint == 33) { tracker.transform.position = waypoint34.transform.position; }
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);

        if (other.CompareTag("AICar"))
        {
            print(waypoint);

            GetComponent<BoxCollider>().enabled = false;

            waypoint++;
            if (waypoint == 34) { waypoint = 0; }

            yield return new WaitForSeconds(1);

            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
