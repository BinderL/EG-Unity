using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Vuforia;

public class Vb_anim_leaf : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObjLeaf;
    public GameObject AnimatorObject;
    public Animator chesttopAni;
    public bool active;
    //Transform[] childs = new Transform [10];
    //ublic GameObject myGameObject;

    void Start()
    {


        //vbBtnObjLeaf = transform.Find("Leafbtn").gameObject;
        //AnimatorObject = transform.Find("chesttop").gameObject;
        vbBtnObjLeaf.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
        chesttopAni = AnimatorObject.GetComponent<Animator>();
        //chesttopAni.GetComponent<Animator>();
        active = false;
    }

    void Update()
    {
        //vbBtnObjLeaf = transform.Find("Leafbtn").gameObject;
        //AnimatorObject = transform.Find("chesttop").gameObject;
        vbBtnObjLeaf.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        chesttopAni = AnimatorObject.GetComponent<Animator>();
        //chesttopAni.GetComponent<Animator>();
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

    public static Transform[] GetTopLevelChildren(Transform Parent)
    {
        Transform[] Children = new Transform[Parent.childCount];
        for (int ID = 0; ID < Parent.childCount; ID++)
        {
            Children[ID] = Parent.GetChild(ID);
        }
        return Children;
    }
}
