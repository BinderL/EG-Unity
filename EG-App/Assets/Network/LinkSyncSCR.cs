using System.Collections;
using System.Collections.Generic;
using SharpConnect;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using UnityEngine;


public class LinkSyncSCR : MonoBehaviour {
    public Connector test = new Connector();
    string lastMessage;
    public Transform PlayerCoord;

	// Use this for initialization
	void Start () {
        Debug.Log(test.fnConnectResult("176.165.32.111", 8888, System.Environment.MachineName));
        if(test.res !="")
        {
            Debug.Log(test.res);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnApplicationQuit()
    {
        try { test.fnDisconnect(); }
        catch {}
    }
}
