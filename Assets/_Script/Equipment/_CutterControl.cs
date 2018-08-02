using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CutterControl : MonoBehaviour {

    public ParticleSystem spark;
    public AudioClip sawIdle, sawHit;
    public GameObject scratch;
    public Transform scratchLocate;
    Vector3 fwd;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<AudioSource>().clip = sawIdle;
        gameObject.GetComponent<AudioSource>().Play();

        spark.Stop(true);

    }
	
	// Update is called once per frame
	void Update () {
        
        fwd = transform.TransformDirection(Vector3.forward);
        
        Debug.DrawRay(transform.position, fwd * 10, Color.green);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Door")
        {
            Debug.Log("Hit");
            spark.Play(true);

            gameObject.GetComponent<AudioSource>().clip = sawHit;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            Ray ray = Camera.main.ScreenPointToRay(fwd);
            RaycastHit hit = new RaycastHit();
            GameObject dummy = Instantiate(scratch, scratchLocate.position, scratchLocate.rotation);
            dummy.transform.position = new Vector3(scratchLocate.position.x, scratchLocate.position.y, 0.55f * collision.gameObject.transform.position.z);
            //dummy.transform.rotation = Quaternion.Euler();
            //Debug.Log(hit.distance);
            
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            gameObject.GetComponent<AudioSource>().clip = sawIdle;
            gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Out");
            spark.Stop(true);
        }
    }
}
