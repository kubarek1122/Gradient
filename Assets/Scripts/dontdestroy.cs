using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestroy : MonoBehaviour
{
    public void Awake()
    {
        
        DontDestroyOnLoad(this);
    }

    void Start()
    {

    }
}
