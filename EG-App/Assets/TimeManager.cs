using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour

{

    public GUIText scoreText;
    private float time_Begin;
    private float time_rest;
    void Start()
    {
        time_Begin = 1500;
        time_rest = 0;
        Updatetime();
    }

    void Update()
    {

        time_Begin -= Time.deltaTime;

        if (time_Begin <= 0.0f)
        {
            TimerEnded();
        }
        else
        {
            Addtime(time_Begin);
        }

    }

    void TimerEnded()
    {
        //Launch the lose screen.
    }

    public void Addtime(float time)
    {
        time_rest = time;
        Updatetime();
    }

    void Updatetime()
    {
        scoreText.text = "Time: " + time_rest;
    }
}
