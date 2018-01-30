using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publisher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
