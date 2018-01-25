using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_button : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObj;
	public Animator ballAni;


	void Start () 
	{
		vbBtnObj = GameObject.Find ("Natoobtn");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		ballAni.GetComponent<Animator>();

	}


	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
	{
		ballAni.Play("ball_anim");
		Debug.Log("ON");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
		ballAni.Play("none");
		Debug.Log("OFF");
	}
}
