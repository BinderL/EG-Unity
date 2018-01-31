using System.Collections;
using System.Collections.Generic;
using SharpConnect;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using UnityEngine;



public class LinkSyncSCR : MonoBehaviour {
    public Connector test2 = new Connector();
    string lastMessage;
    public Transform PlayerCoord;

    // Use this for initialization
    void Start () {


        Debug.Log(test2.fnConnectResult("176.165.32.111", 8888, System.Environment.MachineName));
        if(test2.res !="")
        {
            Debug.Log(test2.res);
        }
	}
	
	// Update is called once per frame
	void Update () {
    }

    private void OnApplicationQuit()
    {
        try { test2.fnDisconnect(); }
        catch {}
    }
}
