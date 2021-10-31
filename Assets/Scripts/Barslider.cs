using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barslider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Slider();
    }
    void Slider()
    {
        int touchNum = Input.touchCount;  
  
        if (touchNum > 0)  
        {  
            Touch touch = Input.GetTouch(0);  
            if (touch.phase == TouchPhase.Moved)  
            {  
                Vector3 dir = new Vector3(touch.deltaPosition.x, touch.deltaPosition.y, 0f) * 0.1f;  
                transform.Translate(dir);  
            }  
        }  
    }
}
