using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachingController : MonoBehaviour {


    public int glass2durability;

    public GameObject[] glass2;
    public GameObject[] glass3;
    public GameObject door1, door2, middle;

	// Use this for initialization
	void Start () {

        glass2durability = 5;

        //StartCoroutine("Glasses2Break");
	}

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "em_hammer")
        {

            glass2durability--;
            if (glass2durability == 0)
            {
                if (glass2[0].activeSelf)
                {
                    glass2[0].SetActive(false);
                    glass2[1].SetActive(true);
                }
                else if (glass2[1].activeSelf)
                {
                    glass2[1].SetActive(false);
                    glass2[2].SetActive(true);
                }
                else if (glass2[2].activeSelf)
                    glass2[2].SetActive(false);

                glass2durability = 5;
            }
        }
    }

    IEnumerator Glasses2Break()
    {
        yield return new WaitForSeconds(1f);
        glass2[0].SetActive(false);
        glass2[1].SetActive(true);
        yield return new WaitForSeconds(3f);
        glass2[1].SetActive(false);
        glass2[2].SetActive(true);
        yield return new WaitForSeconds(3f);
        glass2[2].SetActive(false);
        StartCoroutine("Glasses3Break");
    }

    IEnumerator Glasses3Break()
    {
        yield return new WaitForSeconds(1f);
        glass3[0].SetActive(false);
        glass3[1].SetActive(true);
        yield return new WaitForSeconds(3f);
        glass3[1].SetActive(false);
        glass3[2].SetActive(true);
        yield return new WaitForSeconds(3f);
        glass3[2].SetActive(false);
        glass3[3].SetActive(true);
        yield return new WaitForSeconds(3f);
        glass3[3].SetActive(false);
        StartCoroutine("Door1Detach");
    }

    public IEnumerator Door1Detach()
    {
        yield return new WaitForSeconds(3f);
        LeanTween.moveLocalX(door1, 1.398f, 2f);
        yield return new WaitForSeconds(3f);
        door1.SetActive(false);
        //StartCoroutine("Door2Detach");
    }
    public IEnumerator Door2Detach()
    {
        yield return new WaitForSeconds(1f);
        LeanTween.moveLocalX(door2, 1.604f, 2f);
        yield return new WaitForSeconds(3f);
        door2.SetActive(false);
        //StartCoroutine("MiddleDetach");
    }
    IEnumerator MiddleDetach()
    {
        yield return new WaitForSeconds(1f);
        LeanTween.moveLocalX(middle, 1.66f, 2f);
        yield return new WaitForSeconds(3f);
        middle.SetActive(false);
    }

}
