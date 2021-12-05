using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsManager : MonoBehaviour
{
    public bool ingredient1;
    public bool ingredient2;
    public bool ingredient3;
    public bool ingredient4;
    public bool ingredient5;
    public bool AR;
    // Start is called before the first frame update
    void Start()
    {
        ingredient1 = true;
        ingredient2 = true;
        ingredient3 = true;
        ingredient4 = true;
        ingredient5 = true;
        AR = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(ingredient4==false || ingredient5==false)
        {
            AR = false;
        }
        else
        {
            AR = true;
        }
    }
    public void ARlearning()//轉換頁面去AR教學
    {
        if(AR)
        {
            Debug.Log("AR教學開始!");
        }
        else
        {
            Debug.Log("披薩怎麼能少了醬料或餅皮呢?");
        }
    }
    public void Ingredient1()
    {
        if(ingredient1)
        {
            ingredient1 = false;
            GameManager.instance.ingredient1 = false;
        }
        else
        {
            ingredient1 = true;
            GameManager.instance.ingredient1 = true;
        }
    }
    public void Ingredient2()
    {
        if(ingredient2)
        {
            ingredient2 = false;
            GameManager.instance.ingredient2 = false;
        }
        else
        {
            ingredient2 = true;
            GameManager.instance.ingredient2 = true;
        }
    }
    public void Ingredient3()
    {
        if(ingredient3)
        {
            ingredient3 = false;
            GameManager.instance.ingredient3 = false;
        }
        else
        {
            ingredient3 = true;
            GameManager.instance.ingredient3 = true;
        }
    }
    public void Ingredient4()
    {
        if(ingredient4)
        {
            ingredient4 = false;
            GameManager.instance.ingredient4 = false;
        }
        else
        {
            ingredient4 = true;
            GameManager.instance.ingredient4 = true;
        }
    }
    public void Ingredient5()
    {
        if(ingredient5)
        {
            ingredient5 = false;
            GameManager.instance.ingredient5 = false;
        }
        else
        {
            ingredient5 = true;
            GameManager.instance.ingredient5 = true;
        }
    }
    public void Page1()
    {
        ingredient1 = true;
        ingredient2 = true;
        ingredient3 = true;
        ingredient4 = true;
        ingredient5 = true;
        GameManager.instance.ingredient1 = true;
        GameManager.instance.ingredient2 = true;
        GameManager.instance.ingredient3 = true;
        GameManager.instance.ingredient4 = true;
        GameManager.instance.ingredient5 = true;
    }
}
