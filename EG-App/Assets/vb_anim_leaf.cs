using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb_anim_leaf : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbBtnObjLeaf;
    public Animator chesttopAni;
    public bool active;


    void Start()
    {

        vbBtnObjLeaf = transform.Find("Leafbtn").gameObject;
        vbBtnObjLeaf.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        chesttopAni.GetComponent<Animator>();
        active = false;
    }

    void Update()
    {
        vbBtnObjLeaf = transform.Find("Leafbtn").gameObject;
        //vbBtnObjLeaf = GameObject.Find("Leafbtn");
        vbBtnObjLeaf.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        chesttopAni.GetComponent<Animator>();
    }


    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        if (active == false)
        {
            chesttopAni.Play("chesttop_animation");
            active = true;
        }
        Debug.Log("ON_SHIELD");
    }
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        //chesttopAni.Play ("none");
        Debug.Log("OFF_SHIELD");
    }
}
