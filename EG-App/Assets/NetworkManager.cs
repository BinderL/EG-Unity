using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour {

    private const string typeName = "EscapeGame";
    private const string gameName = "chest";
    //MasterServer.ipAddress = “127.0.0.1″;

    // Use this for initialization
    void Start () {


    }
    

    // Update is called once per frame
    void Update () {
		
	}


    private void StartServer()
    {
        Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
        MasterServer.RegisterHost(typeName, gameName);
    }

    public GameObject buttonPrefab;

    void OnServerInitialized()
    {
        Debug.Log("Server Initializied");
        //Spawnchest();
    }


    private HostData[] hostList;

    private void RefreshHostList()
    {
        MasterServer.RequestHostList(typeName);
    }

    void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        if (msEvent == MasterServerEvent.HostListReceived)
            hostList = MasterServer.PollHostList();
    }

    private void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
    }

    void OnConnectedToServer()
    {
        Debug.Log("Server Joined");
        //Spawnchest();
    }


    //private void Spawnchest()
    //{
    //    Network.Instantiate(buttonPrefab, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
    //}

    //void Update()
    //{
    //    if (networkView.isMine)
    //    {
    //        InputMovement();
    //        InputColorChange();
    //    }
    //    else
    //    {
    //        SyncedMovement();
    //    }
    //}

    //private void InputColorChange()
    //{
    //    if (Input.GetKeyDown(KeyCode.R))
    //        ChangeColorTo(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
    //}

    //[RPC]
    //void ChangeColorTo(Vector3 color)
    //{
    //    renderer.material.color = new Color(color.x, color.y, color.z, 1f);

    //    if (networkView.isMine)
    //        networkView.RPC("ChangeColorTo", RPCMode.OthersBuffered, color);
    //}



    void OnGUI()
    {
        if (!Network.isClient && !Network.isServer)
        {
            if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
                StartServer();

            if (GUI.Button(new Rect(100, 250, 250, 100), "Refresh Hosts"))
                RefreshHostList();

            if (hostList != null)
            {
                for (int i = 0; i < hostList.Length; i++)
                {
                    if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName))
                        JoinServer(hostList[i]);
                }
            }
        }
    }
}
