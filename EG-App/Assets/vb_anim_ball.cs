using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim_ball : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjShield;
	public Animator ballAni;


	void Start () {
		vbBtnObjShield = GameObject.Find ("Shieldbtn");
		vbBtnObjShield.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		ballAni.GetComponent<Animator> ();
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		ballAni.Play ("ball_animation");
		Debug.Log ("ON_BALL");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		ballAni.Play ("none");
		Debug.Log ("OFF_BALL");
	}
}
