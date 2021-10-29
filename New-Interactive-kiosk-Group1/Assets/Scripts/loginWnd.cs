using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loginWnd : MonoBehaviour
{
    public GameObject helpWnd;
    public GameObject languageWnd;
    public Image imgLanguage;
    public Sprite englishSpr;
    public GameObject txtLanguage;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        helpWnd.SetActive(false);
        languageWnd.SetActive(false);
    }

    private void Update()
    {

    }

    public void OnEnterClick()
    {
        anim.enabled = true;
        anim.SetTrigger("Enter");
        StartCoroutine(CloseLoginWnd());
    }

    IEnumerator CloseLoginWnd()
    {
        yield return new WaitForSeconds(3);
        GameRoot.Instance.OnLoginClick();
    }

    /// <summary>
    /// 点击帮助界面
    /// </summary>
    public void OnHelpWndClick()
    {
        helpWnd.SetActive(true);
        StartCoroutine(CloseHelpWnd());
    }

    IEnumerator CloseHelpWnd()
    {
        yield return new WaitForSeconds(2);
        helpWnd.SetActive(false);
    }

    /// <summary>
    /// 点击语言界面
    /// </summary>
    public void OnLanguageWndCkick()
    {
        languageWnd.SetActive(true);
    }

    /// <summary>
    /// 选择语言-英语
    /// </summary>
    public void OnEnglishClick()
    {
        languageWnd.SetActive(false);
        txtLanguage.SetActive(false);
        imgLanguage.sprite = englishSpr;
    }
}
