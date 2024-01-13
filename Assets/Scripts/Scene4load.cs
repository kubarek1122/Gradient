using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4load : MonoBehaviour
{
    public int ifmove3=0;
    public int ifmove4 = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player"&&(ifmove3==1||ifmove4==1))
        { 
         ifmove3 =  2;
         ifmove4 = 2;
            StartCoroutine(waiter());
        }
    }
    IEnumerator waiter()
    {
        
        yield return new WaitForSeconds(1);
        
        SceneManager.LoadScene("4", LoadSceneMode.Single);

    }
}
