using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Enigme : NetworkBehaviour
{

    public string title;
    public string msg;
    public string time;
    public string solution;
    public GameObject coffrePrefab;
    public GameObject boutonPrefab;

    // Use this for initialization
    public override void OnStartServer()
    {
        var spawnPositionC = new Vector3(0, 0, 0.8f);
        var spawnRotationC = Quaternion.Euler(0, -90, 0);
        var spawnPositionB = new Vector3(0, 0, 0);
        var spawnRotationB = Quaternion.Euler(0, 0, 0);
        var coffre = (GameObject)Instantiate(coffrePrefab, spawnPositionC, spawnRotationC);
        NetworkServer.Spawn(coffre);
        GameObject stadium = GameObject.FindGameObjectWithTag("Enigme1");
        coffre.transform.SetParent(stadium.transform, false);

        var bouton = (GameObject)Instantiate(boutonPrefab, spawnPositionB, spawnRotationB);
        NetworkServer.Spawn(bouton);
        bouton.transform.SetParent(stadium.transform, false);

        Vb_anim_leaf Bouton = GetComponentInParent<Vb_anim_leaf>();
        Bouton.vbBtnObjLeaf = GameObject.FindGameObjectWithTag("Player");
        GameObject Animator = GameObject.FindGameObjectWithTag("GameController");
        Bouton.AnimatorObject = Animator;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
