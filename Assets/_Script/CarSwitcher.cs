using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwitcher : MonoBehaviour {

    public Animator[] carList;

	// Use this for initialization
	void Awake () {
        carList = GetComponentsInChildren<Animator>();
        for(int i =1; i < carList.Length; i++)
        {
            carList[i].gameObject.SetActive(false);
        }
	}

    void Start()
    {
        Debug.Log("Say Hi");
    }

    // Update is called once per frame
    //void Update () {

    //}

    public void RandomCar()
    {
        if(carList != null)
        {
            int randomIndex = Random.Range(1, carList.Length - 1);
            for (int i = 1; i < carList.Length; i++)
            {
                carList[i].gameObject.SetActive(false);
            }
            carList[randomIndex].gameObject.SetActive(true);
        }
    }
}
