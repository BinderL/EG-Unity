using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour

{

    public GUIText scoreText;
    public float time_Begin;
    private float time_rest;
    private float time_rest_a;
    private float time_refresh;
    private Rect labelRect = new Rect(350, 10, 150, 100);
    private bool loose;
    void Start()
    {
        loose = false;
        time_Begin = 10;
        time_rest = time_Begin;
        Updatetime();
        time_refresh = 0.5f;    }

    private IEnumerator Wait_timetodisplay(float seconds)
    {

        yield return new WaitForSeconds(seconds);

        if (time_Begin <= 0.0f)
        {
            TimerEnded();
        }
        else
        {
            Addtime(time_Begin);
        }

    }

    void Update()
    {

        time_Begin -= Time.deltaTime;
        StartCoroutine(Wait_timetodisplay(time_refresh));
    }

    private void TimerEnded()
    {
        loose = true;
    }

    public void Addtime(float time)
    {
        time_rest = time;
        Updatetime();
    }

    private void Updatetime()
    {
        scoreText.text = "Time: " + time_rest;
        
    }

    private void OnGUI()
    {
        time_rest_a = RoundValue(time_rest, 1f);
        if (!loose)
            GUI.Label(labelRect, "time" + time_rest_a);
        else
            GUI.Label(labelRect, "Game Over");
    }

    public static float RoundValue(float num, float precision)
    {
        return Mathf.Floor(num * precision + 0.5f) / precision;
    }
}
