using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFaded : MonoBehaviour
{
    Image image;
    private float i;
    public float fadspeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        i=1;
    }

    // Update is called once per frame
    void Update()
    {
        Fade();
    }
    void Fade()
    {
        i -= fadspeed*Time.deltaTime;
        if(i<=0)
        {
            i=0;
        }
        image.color = new Color(1, 1, 1, i);
    }
}
