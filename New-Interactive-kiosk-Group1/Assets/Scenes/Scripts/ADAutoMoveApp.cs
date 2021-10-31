using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADAutoMoveApp : MonoBehaviour
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
        if (GetComponent<RectTransform>().anchoredPosition.x < -387.5f)
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector3(775, 0, 0);
        }
    }
}
