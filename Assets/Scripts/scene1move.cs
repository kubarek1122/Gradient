using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1move : MonoBehaviour
{

    public float speed = 0.2f;
    public GameObject sphere;
    public GameObject camera;
    public float counter = 0;

    public Transform target;

    public scene1cameramove boolc;
    public Rigidbody rigidbody;

    void Start()
    {
        Cursor.visible = false;

    }


    void Update()
    {
        if(boolc.ifmove==false)
        { 
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
                if(pos.y> 0.8559413f)
                {
                    pos.x += speed * Time.deltaTime;
                    sphere.transform.localScale -= gameObject.transform.localScale * (Time.deltaTime * 8*speed);
                    pos.y -= speed * (0.5f) * Time.deltaTime;
                    counter--;
                    Debug.Log(counter);
                }
            
        }
        if (Input.GetKey("s"))
        {
            pos.x -= speed * Time.deltaTime;
            sphere.transform.localScale += gameObject.transform.localScale * (Time.deltaTime * 8*speed);
            pos.y += speed *(0.5f) * Time.deltaTime;
            counter++;
            Debug.Log(counter);
        }
        if (Input.GetKey("d"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.z += speed * Time.deltaTime;
        }

        transform.position = pos;

        }
        else
        {
            rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        }
       
        if (counter>65)
        {
            boolc.ifmove = true;
        }
    }
}
