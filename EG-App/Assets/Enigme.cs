using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme : MonoBehaviour {

    public string title;
    public string msg;
    public string time;
    public string solution;

    // Use this for initialization
    void Start () {
        GameObject stadium = GameObject.FindGameObjectWithTag("Enigme1");
        transform.SetParent(stadium.transform, false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
