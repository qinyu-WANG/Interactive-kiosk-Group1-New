using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    public static GameRoot Instance;

    public GameObject welcomeWnd;
    public GameObject loginWnd;
    public GameObject menuWnd;
    public GameObject helloMike;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        welcomeWnd.SetActive(true);
        loginWnd.SetActive(false);
        menuWnd.SetActive(false);
    }

    /// <summary>
    /// 点击广告按钮
    /// </summary>
    public void OnAdClick()
    {
        welcomeWnd.SetActive(false);
        loginWnd.SetActive(true);
    }

    /// <summary>
    /// 点击点餐按钮
    /// </summary>
    public void OnOrderClick()
    {
        loginWnd.SetActive(false);
        menuWnd.SetActive(true);
        helloMike.SetActive(false);
    }

    /// <summary>
    /// 点击登录按钮
    /// </summary>
    public void OnLoginClick()
    {
        loginWnd.SetActive(false);
        menuWnd.SetActive(true);
    }
}
