using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _UIManager : MonoBehaviour {

    public static _UIManager instance;

    public GameObject[] glassHint, doorHint, clawHint;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GlassControl(bool value)
    {
        foreach(GameObject clue in glassHint)
        {
            clue.SetActive(value);
        }
    }

    public void DoorControl(bool value)
    {
        foreach (GameObject clue in doorHint)
        {
            clue.SetActive(value);
        }
    }

    public void ClawControl(bool value)
    {
        foreach (GameObject clue in clawHint)
        {
            clue.SetActive(value);
        }
    }
}
