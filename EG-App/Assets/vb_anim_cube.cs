using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim_cube : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjAstro;
	public Animator cubeAni;


	void Start () {
		vbBtnObjAstro = GameObject.Find ("Astrobtn");
		vbBtnObjAstro.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		cubeAni.GetComponent<Animator> ();
	}
		
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		cubeAni.Play ("cube_animation");
		Debug.Log ("ON_CUBE");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		cubeAni.Play ("none");
		Debug.Log ("OFF_CUBE");
	}
}
