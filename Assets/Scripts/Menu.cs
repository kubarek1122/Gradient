using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public Animator anim;
    public static bool jest;


    public EventSystem eventSystem;
   // public GameObject selectedObject;
    public GameObject Start;
    public GameObject S;
    public GameObject T2;
    public GameObject A;
    public GameObject Wyl;
    public GameObject R;
    public GameObject T;
    public GameObject start;
    public GameObject title;
    public GameObject title2;


    public int i = 0;
    public int j = 0;

    void Awake()
    {
        i = 0;
        j = 0;
        jest = false;
        title.SetActive(true);
        S.SetActive(false);
        T.SetActive(false);
        A.SetActive(false);
        R.SetActive(false);
        T2.SetActive(false);
        title2.SetActive(false);

        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;
    }
    private void Update()
    {
        if(i==5)
        {
            //SceneManager.LoadScene("1", LoadSceneMode.Single);
            jest = true;

        }
        else if(i==10)
        {
            Application.Quit();
        }
        if (j == 1)
        {
            title.SetActive(false);
            title2.SetActive(true);
            S.SetActive(true);
            T.SetActive(true);
            A.SetActive(true);
            R.SetActive(true);
            T2.SetActive(true);
            anim.SetTrigger("S");

        }
    }

    public void startt()
    {
        Destroy(Start);
        j++;
    }
    public void ipps()
    {
        if (j == 1)
        {
            i++;
            Destroy(S);
        }
    }
  
    public void ippt()
    {
        if (j == 1)
        {
            i++;
            Destroy(T);
        }
    }
    public void ippa()
    {
        if (j == 1)
        {
            i++;
            Destroy(A);
        }
    }
    public void ippr()
    {
        if (j == 1)
        {
            i++;
            Destroy(R);
        }
    }
    public void ippt2()
    {
        if (j == 1)
        {
            i++;
            Destroy(T2);
        }
    }
    public void ippquit()
    {
        if (j == 1)
        {
            i = 10;
            Destroy(Wyl);
        }
    }

}