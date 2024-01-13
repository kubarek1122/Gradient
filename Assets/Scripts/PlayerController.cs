using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static bool jest;
    public GameObject ten;
    public float speed = 0.3f;
    public float ysp = 0.01f;
    Vector3 v;
    public float rotation=1f;

    private void Start()
    {
        v.Set(rotation, 0, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, ysp, -speed * Time.deltaTime);
            if(transform.rotation.x<90)
            transform.Rotate(-v);
        }
        if(transform.position.y>0.9)
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -ysp, speed * Time.deltaTime);
            if (transform.rotation.x < 90)
                transform.Rotate(v);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Object.Destroy(ten);
        jest = true;
    }
}
