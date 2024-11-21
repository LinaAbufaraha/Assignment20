using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public float deg = 0f;
    public float angleInc = 0.5f;

    //Vector3 originalRotation;

    Quaternion originalRotation; //I used the Quaternion (for more stability )to avoid unexpected problems that were appearing


    void Start()
    {
        originalRotation = transform.localRotation;   
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            deg = deg + angleInc;
            deg= Mathf.Clamp(deg,-80,0);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            deg = deg - angleInc;
            deg= Mathf.Clamp(deg,-80,0);
        }

        //transform.localRotation = Quaternion.Euler(new Vector3(originalRotation.x, originalRotation.y, deg));
        transform.localRotation = originalRotation * Quaternion.Euler(0, 0, deg);
        
    }
}
