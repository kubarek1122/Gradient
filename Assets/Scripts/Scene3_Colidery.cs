using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_Colidery : MonoBehaviour
{
    public Transform Plane;
    public float speed = 0.2f;
    public float left;
    public float right;

    public Scene4load boolmove;
    public Scene4load boolmove2;

    private void OnTriggerStay(Collider other)
    {
        if (Plane.position.x <= right && Plane.position.x >= -20 && (boolmove.ifmove3 == 1 || boolmove.ifmove3 == 0) && ( boolmove2.ifmove4==1|| boolmove2.ifmove4 == 0))
        {
            if (other.gameObject.tag == "Left" && Input.GetKey(KeyCode.A))
            {
                Plane.transform.Translate(0, 0, -speed * Time.deltaTime);
            }
            if (other.gameObject.tag == "Right" && Input.GetKey(KeyCode.D) && (boolmove.ifmove3 == 1 || boolmove.ifmove3 == 0) && (boolmove2.ifmove4== 1 || boolmove2.ifmove4 == 0))
            {
                Plane.transform.Translate(0, 0, speed * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Switch")
        {
            boolmove.ifmove3 = 1;
            boolmove2.ifmove4 = 1;
        }
    }
}
