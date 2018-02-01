using System.Collections;
using UnityEngine;
using Vuforia;

public class introduction : MonoBehaviour {

    public float time_wait=5;

	// Use this for initialization
	void Start () {
       StartCoroutine(Wait_scene(time_wait));

    }

    private void Update()
    {
        
    }

    private IEnumerator Wait_scene(float seconds)
    {

        yield return new WaitForSeconds(seconds);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");

    }
}
