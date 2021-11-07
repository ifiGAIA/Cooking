using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesSwitch : MonoBehaviour
{
    public GameObject pageinit;
    public GameObject page1;
    public GameObject[] page2;
    public bool p1;
    public bool p2;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        page1.SetActive(true);
        for(int i=0; i<4; i++)
        {
            page2[i].SetActive(false);
        }
        p1 = false;
        p2 = false;
        Time();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Time()
    {
        Invoke("InitPageToPage1",time);
    }
    void InitPageToPage1()
    {
        pageinit.SetActive(false);
        page1.SetActive(true);
        p1 = true;
    }
    public void SwitchtoPages_Margaret()
    {
        //第一頁去第二頁
        if(p1 == true && p2 == false)
        {
            page1.SetActive(false);
            page2[0].SetActive(true);
            p1 = false;
            p2 = true;
        }
    }
    public void SwitchtoPages_Hawaii()
    {
        //第一頁去第二頁
        if(p1 == true && p2 == false)
        {
            page1.SetActive(false);
            page2[1].SetActive(true);
            p1 = false;
            p2 = true;
        }
    }
    public void SwitchtoPages_Seafood()
    {
        //第一頁去第二頁
        if(p1 == true && p2 == false)
        {
            page1.SetActive(false);
            page2[2].SetActive(true);
            p1 = false;
            p2 = true;
        }
    }
    public void SwitchtoPages_Vegetable()
    {
        //第一頁去第二頁
        if(p1 == true && p2 == false)
        {
            page1.SetActive(false);
            page2[3].SetActive(true);
            p1 = false;
            p2 = true;
        }
    }
    public void SwitchtoprePages()
    {
        //第二頁去第一頁
        if(p1 == false)
        {
            page1.SetActive(true);
            for(int i=0; i<4; i++)
            {
                page2[i].SetActive(false);
            }
            p2 = false;
            p1 = true;
        }
    }
    public void testSwitchscene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
