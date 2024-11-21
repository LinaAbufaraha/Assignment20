using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand3 : MonoBehaviour
{
    public float deg = 0f;
    public float angleInc = 0.25f;
    Vector3 currentRotation;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            deg = deg + angleInc;
            deg= Mathf.Clamp(deg,-40,0);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            deg = deg - angleInc;
            deg= Mathf.Clamp(deg,-40,0);
        }

        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, deg));
        
    }
}
