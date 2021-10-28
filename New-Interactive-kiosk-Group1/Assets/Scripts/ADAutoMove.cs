using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADAutoMove : MonoBehaviour
{
    public int adMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * adMoveSpeed, 0, 0);
        if (GetComponent<RectTransform>().anchoredPosition.x < -1244)
        {
            Debug.Log(111);
            GetComponent<RectTransform>().anchoredPosition = new Vector3(2967.5f, 0, 0);
        }
    }
}
