using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim_shield : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjShield;
	public Animator chesttopAni;
    public delegate void fct();

	public bool active;


	void Start () {
		vbBtnObjShield = GameObject.Find ("Shieldbtn");
		vbBtnObjShield.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		chesttopAni.GetComponent<Animator> ();
        active = false;
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		if (active == false) {
            gestion_jeu.Instance.popup(2);
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
