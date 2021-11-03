using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject mainWnd;
    public GameObject addressWnd;
    public GameObject menuWnd;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    private void Init()
    {
        mainWnd.SetActive(true);
        addressWnd.SetActive(false);
        menuWnd.SetActive(false);
    }

    public void OnPickUpClick()
    {
        mainWnd.SetActive(false);
        menuWnd.SetActive(true);
    }

    public void OnTakeawayClick()
    {
        mainWnd.SetActive(false);
        addressWnd.SetActive(true);
    }

    public void OnPickUpBackMainClick()
    {
        addressWnd.SetActive(false);
        mainWnd.SetActive(true);
    }
}
