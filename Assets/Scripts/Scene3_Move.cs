using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_Move : MonoBehaviour
{
    public float speed = 0.1f;

    public Scene4load boolmove;
    public Scene4load boolmove2;


    void FixedUpdate()
    {
        
            if (Input.GetKey(KeyCode.A)&& (boolmove.ifmove3 == 1 || boolmove.ifmove3 == 0)&& (boolmove2.ifmove4 == 1 || boolmove2.ifmove4 == 0))
            {
                Vector3 position = this.transform.position;
                position.x -= speed;
                this.transform.position = position;
            }
           if (Input.GetKey(KeyCode.D) && (boolmove.ifmove3 == 1 || boolmove.ifmove3 == 0) && (boolmove2.ifmove4 == 1 || boolmove2.ifmove4 == 0))
            {
                Vector3 position = this.transform.position;
                position.x += speed;
                this.transform.position = position;
            }
        
    }   
}