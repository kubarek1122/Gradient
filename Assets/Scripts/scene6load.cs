using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene6load : MonoBehaviour
{
    public static bool jest;
    void Start()
    {

    }

    void Update()
    { 
    
    }
    void OnTriggerEnter(Collider other)
    {
        jest = true;
        //StartCoroutine(waiter());
    }
    /*IEnumerator waiter()
    {

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("6", LoadSceneMode.Single);

    }*/
}
