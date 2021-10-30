using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesSwitch : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public bool p1;
    public bool p2;
    public bool p3;
    // Start is called before the first frame update
    void Start()
    {
        page2.SetActive(false);
        page3.SetActive(false);
        p1 = true;
        p2 = false;
        p3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwitchtonextPages()
    {
        //第一頁去第二頁
        if(p1 == true && p2 == false && p3 == false)
        {
            page1.SetActive(false);
            page2.SetActive(true);
            p1 = false;
            p2 = true;
        }
        //第二頁去第三頁
        else if(p2 == true && p1 == false && p3 == false)
        {
            page2.SetActive(false);
            page3.SetActive(true);
            p2 = false;
            p3 = true;
        }
    }
    public void SwitchtoprePages()
    {
        //第二頁去第一頁
        if(p2 == true && p1 == false && p3 == false)
        {
            page2.SetActive(false);
            page1.SetActive(true);
            p2 = false;
            p1 = true;
        }
        //第三頁去第二頁
        else if(p3 == true && p1 == false && p2 == false)
        {
            page3.SetActive(false);
            page2.SetActive(true);
            p3 = false;
            p2 = true;
        }
    }
    public void testSwitchscene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
