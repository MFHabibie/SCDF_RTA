using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrowdMaker : MonoBehaviour {

    public float groupDelayTime = 1.5f;

    public GameObject[] carGroup;

	// Use this for initialization
	void Start () {
        StartCoroutine(DelayCarGroup());
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}

    IEnumerator DelayCarGroup()
    {
        int i = 1;
        while(i < carGroup.Length)
        {
            yield return new WaitForSeconds(groupDelayTime);
            carGroup[i].SetActive(true);
            i++;
        }
    }
}
