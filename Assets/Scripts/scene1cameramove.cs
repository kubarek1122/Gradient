using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scene1cameramove : MonoBehaviour
{

    public Transform endMarker = null;
    public bool ifmove=false;
    public Quaternion rotationn;


    void Start()
    {
        rotationn = Quaternion.Euler(new Vector3(8.175f, 90f, 0f));

    }

    void Update()
    {
        if(ifmove)
        {
            transform.position = Vector3.Lerp(transform.position, endMarker.position, Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationn, Time.deltaTime * 0.8f);
            StartCoroutine(waiter());
            
        }
        

    }

    IEnumerator waiter()
    {
        
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("2", LoadSceneMode.Single);

    }
}
