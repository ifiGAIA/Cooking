using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class FoodSelect : MonoBehaviour
{
    private bool hisselect = false;
    private bool pisselect = false;
    public Button button_H;
    public Button button_P;
    public Color initcolor;
    public Color selectcolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectFood_H()
    {
        ColorBlock cb = button_H.colors;
        if(hisselect == false)
        {
            cb.normalColor = selectcolor;
            cb.highlightedColor = selectcolor;
            cb.pressedColor = selectcolor;
            cb.selectedColor = selectcolor;
            button_H.colors = cb;
            hisselect = true;
        }
        else if(hisselect ==true)
        {
            cb.normalColor = initcolor;
            cb.highlightedColor = initcolor;
            cb.pressedColor = initcolor;
            cb.selectedColor = initcolor;
            button_H.colors = cb;
            hisselect = false;
        }
    }
    public void SelectFood_P()
    {
        ColorBlock cb = button_P.colors;
        if(pisselect == false)
        {
            cb.normalColor = selectcolor;
            cb.highlightedColor = selectcolor;
            cb.pressedColor = selectcolor;
            cb.selectedColor = selectcolor;
            button_P.colors = cb;
            pisselect = true;
        }
        else if(pisselect ==true)
        {
            cb.normalColor = initcolor;
            cb.highlightedColor = initcolor;
            cb.pressedColor = initcolor;
            cb.selectedColor = initcolor;
            button_P.colors = cb;
            pisselect = false;
        }
    }
}
