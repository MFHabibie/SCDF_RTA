using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakGlass : MonoBehaviour {

    public GameObject[] glass;
    int glassDurability;

    void Start () {
        glassDurability = 7;
    }


    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "SphereCollider")
        {
            if (this.gameObject.name == "Collider1")
            {
                glassDurability--;
                if (glassDurability == 0)
                {
                    if (glass[0].activeSelf)
                    {
                        glass[0].SetActive(false);
                        glass[1].SetActive(true);
                    }
                    else if (glass[1].activeSelf)
                    {
                        glass[1].SetActive(false);
                        glass[2].SetActive(true);
                    }
                    else if (glass[2].activeSelf)
                    {
                        glass[2].SetActive(false);
                        _UIManager.instance.glassHint[0].SetActive(false);
                    }
                    glassDurability = 3;
                }
            }
            else if (this.gameObject.name == "Collider2")
            {
                glassDurability--;
                if (glassDurability == 0)
                {
                    if (glass[0].activeSelf)
                    {
                        glass[0].SetActive(false);
                        glass[1].SetActive(true);
                    }
                    else if (glass[1].activeSelf)
                    {
                        glass[1].SetActive(false);
                        glass[2].SetActive(true);
                    }
                    else if (glass[2].activeSelf)
                    {
                        glass[2].SetActive(false);
                        glass[3].SetActive(true);
                    }
                    else if (glass[3].activeSelf)
                    {
                        glass[3].SetActive(false);
                        _UIManager.instance.glassHint[1].SetActive(false);
                        _GameManager.instance.CuttingDoor();
                    }
                    glassDurability = 3;
                }
            }
        }
    }
}
