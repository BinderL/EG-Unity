using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim_capsule : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjLeaf;
	public Animator capsuleAni;


	void Start () {
		vbBtnObjLeaf = GameObject.Find ("Leafbtn");
		vbBtnObjLeaf.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		capsuleAni.GetComponent<Animator> ();
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		capsuleAni.Play ("capsule_animation");
		Debug.Log ("ON_CAPSULE");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		capsuleAni.Play ("none");
		Debug.Log ("OFF_CAPSULE");
	}
}