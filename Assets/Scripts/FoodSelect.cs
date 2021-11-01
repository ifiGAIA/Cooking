using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class FoodSelect : MonoBehaviour
{
    Image image;
    public Sprite selected;
    public Sprite noselection;
    public bool isselect;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        isselect = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectFood()
    {
        if(isselect == false)
        {
            image.sprite = selected;
            isselect = true;
        }
        else if(isselect ==true)
        {
            image.sprite = noselection;
            isselect = false;
        }
    }
}
