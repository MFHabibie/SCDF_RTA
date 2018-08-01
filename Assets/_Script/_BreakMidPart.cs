using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BreakMidPart : MonoBehaviour {

    public DetachingController dc;

    float count = 0f;
    int breaks = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(breaks >= 2)
        {
            dc.StartCoroutine("MiddleDetach");
            breaks = 0;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "PartTop")
        {
            count += Time.deltaTime;
            if(count > 5f)
            {
                //breaking
                breaks++;
            }
        }
        else if(other.name == "PartBottom")
        {
            count += Time.deltaTime;
            if (count > 5f)
            {
                //breaking
                breaks++;
            }
        }
    }
}
