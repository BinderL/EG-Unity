using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections.Generic;
//using Prototype.NetworkLobby;
[System.Serializable]
public class Scenario
{
    public string title;
    public string msg;
    public string time_sc;
    public string solution;
    //public List<Enigme> enigmeData = new List<Enigme>();
    public List<int> declenchement = new List<int>();
}

//public class Enigme
//{
//    public string title;
//    public string msg;
//    public string time;
//    public string solution;
//}

public class gestion_jeu : NetworkBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
