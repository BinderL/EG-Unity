using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMoov : MonoBehaviour
{
    public float horozontalSpeed = 0.01f;
    public float verticalSpeed = 0.01f;

    void Update()
    {
        if (Input.touchCount >= 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float h = horozontalSpeed * touch.deltaPosition.x;
                float v = verticalSpeed * touch.deltaPosition.y;
                transform.Translate(h, 0, v);
            }
        }
    }
}
