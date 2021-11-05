using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesSwitch : MonoBehaviour
{
    public GameObject pageinit;
    public GameObject page1;
    public GameObject page2;
    public bool p1;
    public bool p2;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        // page1.SetActive(true);
        // page2.SetActive(false);
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
        // page1.SetActive(true);
        p1 = true;
    }
    public void SwitchtonextPages()
    {
        //第一頁去第二頁
        if(p1 == true && p2 == false)
        {
            page1.SetActive(false);
            page2.SetActive(true);
            p1 = false;
            p2 = true;
        }
    }
    public void SwitchtoprePages()
    {
        //第二頁去第一頁
        if(p2 == true && p1 == false)
        {
            page2.SetActive(false);
            page1.SetActive(true);
            p2 = false;
            p1 = true;
        }
    }
    public void testSwitchscene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
