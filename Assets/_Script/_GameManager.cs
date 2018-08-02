using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameManager : MonoBehaviour {

    public static _GameManager instance;

    void Awake()
    {
        instance = this;    
    }

    // Use this for initialization
    void Start () {
        _UIManager.instance.GlassControl(false);
        _UIManager.instance.DoorControl(false);
        _UIManager.instance.ClawControl(false);

        BreakingGlass();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BreakingGlass()
    {
        MessageHandler.instance.ShowMessage("Break the glass with emergency hammer");
        _UIManager.instance.GlassControl(true);
    }

    public void CuttingDoor()
    {
        _UIManager.instance.GlassControl(false);
        MessageHandler.instance.ShowMessage("Cut side door with air body saw");
        _UIManager.instance.DoorControl(true);
    }

    public void BreakingMiddlePart()
    {
        _UIManager.instance.DoorControl(false);
        MessageHandler.instance.ShowMessage("Break the middle car part with steel pipe cutting tool");
        _UIManager.instance.ClawControl(true);
    }
}
