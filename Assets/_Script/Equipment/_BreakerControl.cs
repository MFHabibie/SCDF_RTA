using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BreakerControl : MonoBehaviour {

    public ParticleSystem glass;
    public AudioClip breakerHit;

    // Use this for initialization
    void Start () {
        glass.Stop(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Glass")
        {
            Debug.Log("Hit");
            glass.Play(true);

            gameObject.GetComponent<AudioSource>().clip = breakerHit;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
