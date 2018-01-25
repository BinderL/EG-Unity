using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim_leaf : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjLeaf;
	public Animator chesttopAni;

	public bool active;


	void Start () {
		vbBtnObjLeaf = GameObject.Find ("Leafbtn");
		vbBtnObjLeaf.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		chesttopAni.GetComponent<Animator> ();
		active = false;
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		if (active == false) {
			chesttopAni.Play ("chesttop_animation");
			active = true;
		}
		Debug.Log ("ON_SHIELD");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		//chesttopAni.Play ("none");
		Debug.Log ("OFF_SHIELD");
	}
}
