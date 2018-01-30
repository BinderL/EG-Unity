using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Vuforia;

public class Vb_anim_star : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjStar;
	public Animator chesttopAni;
	public bool active;


	void Start () {
		vbBtnObjStar = GameObject.Find ("Starbtn");
		vbBtnObjStar.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
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

    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
        Vector3 syncPosition = Vector3.zero;
        if (stream.isWriting)
        {
            syncPosition = transform.position;
            stream.Serialize(ref syncPosition);
            Debug.Log("published chest transform");
        }
        else
        {
            stream.Serialize(ref syncPosition);
            transform.position = syncPosition;
            Debug.Log("published chest transform");
        }
    }
}
