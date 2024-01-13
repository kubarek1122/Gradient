using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene6move : MonoBehaviour
{
    public Transform camTrans;
    public static bool jest;
    public float speed=1f;
    public float wspeed = 1f;
    public float speed2 = 1f;
    public float wspeed2 = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        if(camTrans.position.z>-16)
        {
            if (Input.GetKey(KeyCode.S))
            {
                camTrans.Translate(0, wspeed * Time.deltaTime, -speed * Time.deltaTime);
            }
            if (camTrans.position.z < -8)
            {
                speed = speed2;
                wspeed = wspeed2;
            }
        }
        else
        {
            jest = true;
        }
    }
}
