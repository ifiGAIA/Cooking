using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class FoodSelect : MonoBehaviour
{
    Image imagePizza;
    Image imageBurger;
    public GameObject[] Food;
    public Transform[] FoodBar;
    public Sprite[] selected;
    public Sprite[] noselection;
    private bool pizza;
    private bool burger;
    // Start is called before the first frame update
    void Start()
    {
        imagePizza = FoodBar[0].GetChild(0).GetComponent<Image>();
        imageBurger = FoodBar[1].GetChild(0).GetComponent<Image>();
        pizza = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        FoodCheck();
    }
    public void FoodCheck()
    {
        if(pizza)
        {
            imagePizza.sprite = selected[0];
        }
        else
        {
            imagePizza.sprite = noselection[0];
        }
        if(burger)
        {
            imageBurger.sprite = selected[1];
        }
        else
        {
            imageBurger.sprite = noselection[1];
        }
    }
    public void SelectPizza()
    {
        pizza = true;
        burger = false;
        Food[0].SetActive(true);
        Food[1].SetActive(false);
    }
    public void SelectBurger()
    {
        pizza = false;
        burger = true;
        Food[0].SetActive(false);
        Food[1].SetActive(true);
    }
}
