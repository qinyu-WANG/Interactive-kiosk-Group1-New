using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        GetComponent<Image>().color = new Color(255 / 255, 255 / 255, 255 / 255, 255 / 255);
    }

    public void OnPointerExit()
    {
        GetComponent<Image>().color = new Color(255 / 255, 255 / 255, 255 / 255, 0 / 255);
    }
}
