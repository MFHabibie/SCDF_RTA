using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateModel : MonoBehaviour {

    public GameObject objModel;
    public GameObject otherModel1, otherModel2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "SphereCollider")
        {
            objModel.SetActive(true);
            otherModel1.SetActive(false);
            otherModel2.SetActive(false);
        }
    }
}
