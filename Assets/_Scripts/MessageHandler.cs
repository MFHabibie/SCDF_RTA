using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageHandler : MonoBehaviour {

	public static MessageHandler instance;
	public Text txtMessage;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowMessage(string mssg){
		txtMessage.text = mssg;
		this.gameObject.GetComponent<Animator> ().Play ("Anim_Show_Message");
        StartCoroutine("ShowAndHide");
	}

	public void HideAndShowMessage(string mssg){
		txtMessage.text = mssg;
		this.gameObject.GetComponent<Animator> ().Play ("Anim_HideShow_Message");
	}

	public void HideMessage(){
		this.gameObject.GetComponent<Animator> ().Play ("Anim_Hide_Message");
	}

    IEnumerator ShowAndHide()
    {
        yield return new WaitForSeconds(5f);
        HideMessage();
    }
}
