using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeTrigger : MonoBehaviour {

    public DetachingController dc;
    public int door1, door2, door3, door4, door5, door6, door7, door8;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (door1 == 1 && door2 == 1 && door3 == 1 && door4 == 1)
        {
            door1 = 0;
            dc.StartCoroutine("Door1Detach");
        }

        if (door5 == 1 && door6 == 1 && door7 == 1 && door8 == 1)
        {
            door5 = 0;
            dc.StartCoroutine("Door2Detach");
        }

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "Door1")
        {
            door1 = 1;
            col.enabled = false;
        }
        if (col.name == "Door2")
        {
            door2 = 1;
            col.enabled = false;
        }
        if (col.name == "Door3")
        {
            door3 = 1;
            col.enabled = false;
        }
        if (col.name == "Door4")
        {
            door4 = 1;
            col.enabled = false;
        }
        if (col.name == "Door5")
        {
            door5 = 1;
            col.enabled = false;
        }
        if (col.name == "Door6")
        {
            door6 = 1;
            col.enabled = false;
        }
        if (col.name == "Door7")
        {
            door7 = 1;
            col.enabled = false;
        }
        if (col.name == "Door8")
        {
            door8 = 1;
            col.enabled = false;
        }
    }
}
