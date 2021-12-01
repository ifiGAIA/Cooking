using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool ingredient1;
    public bool ingredient2;
    public bool ingredient3;
    public bool ingredient4;
    public bool ingredient5;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
           DontDestroyOnLoad(this);

        }
        else if (this != instance)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ingredient1 = true;
        ingredient2 = true;
        ingredient3 = true;
        ingredient4 = true;
        ingredient5 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
