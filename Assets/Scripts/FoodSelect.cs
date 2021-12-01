using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class FoodSelect : MonoBehaviour
{
    Image imagePizza;
    Image imageBurger;
    Image imageSubway;
    Image imagePasta;
    Image imageSalad;
    public GameObject[] Food;
    public Transform[] FoodBar;
    public Sprite[] selected;
    public Sprite[] noselection;
    private bool pizza;
    private bool burger;
    private bool subway;
    private bool pasta;
    private bool salad;
    // Start is called before the first frame update
    void Start()
    {
        imagePizza = FoodBar[0].GetChild(0).GetComponent<Image>();
        imageBurger = FoodBar[1].GetChild(0).GetComponent<Image>();
        imageSubway = FoodBar[2].GetChild(0).GetComponent<Image>();
        imagePasta = FoodBar[3].GetChild(0).GetComponent<Image>();
        imageSalad = FoodBar[4].GetChild(0).GetComponent<Image>();
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

        if(subway)
        {
            imageSubway.sprite = selected[2];
        }
        else
        {
            imageSubway.sprite = noselection[2];
        }

        if(pasta)
        {
            imagePasta.sprite = selected[3];
        }
        else
        {
            imagePasta.sprite = noselection[3];
        }

        if(salad)
        {
            imageSalad.sprite = selected[4];
        }
        else
        {
            imageSalad.sprite = noselection[4];
        }
    }
    public void SelectPizza()
    {
        pizza = true;
        burger = false;
        subway = false;
        pasta = false;
        salad = false;
        Food[0].SetActive(true);
        Food[1].SetActive(false);
        Food[2].SetActive(false);
    }
    public void SelectBurger()
    {
        pizza = false;
        burger = true;
        subway = false;
        pasta = false;
        salad = false;
        Food[0].SetActive(false);
        Food[1].SetActive(true);
        Food[2].SetActive(false);
    }
    public void SelectSubway()
    {
        pizza = false;
        burger = false;
        subway = true;
        pasta = false;
        salad = false;
        Food[0].SetActive(false);
        Food[1].SetActive(false);
        Food[2].SetActive(true);
    }
    public void SelectPasta()
    {
        pizza = false;
        burger = false;
        subway = false;
        pasta = true;
        salad = false;
        Food[0].SetActive(false);
        Food[1].SetActive(false);
        Food[2].SetActive(true);
    }
    public void SelectSalad()
    {
        pizza = false;
        burger = false;
        subway = false;
        pasta = false;
        salad = true;
        Food[0].SetActive(false);
        Food[1].SetActive(false);
        Food[2].SetActive(true);
    }
}
