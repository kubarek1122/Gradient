using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene4_PlayerController : MonoBehaviour
{
    public GameObject s;
    public Transform t;
    public Transform target;
    public float camspeed = 1.0f;
    public float speed = 2.0f;
    Vector3 v;
    public Renderer rend;
    float a=1f;
    public float b=0.01f;
    public float transitionTime=1f;
    private bool c = true;
    void Start()
    {
        v.Set(0f, -1.3f, -4.12f);
    }


    void FixedUpdate()
    {
        if(c)
        {
                if(transform.position.y<=1.9)
                {
                    if(Input.GetKey(KeyCode.W))
                    {
                        transform.Translate(0, speed * Time.deltaTime, 0);
                        a += b;
                    }
                }
                if (transform.position.x >= -3.5)
                {
                    if (Input.GetKey(KeyCode.A))
                    {
                        transform.Translate(-speed * Time.deltaTime, 0, 0);
                    }
                }
                if (transform.position.x <= 3.6)
                {
                    if (Input.GetKey(KeyCode.D))
                    {
                        transform.Translate(speed * Time.deltaTime, 0, 0);
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0, -speed * Time.deltaTime, 0);
                    a -= b;
                }
        }
        
        if(transform.position.y<-1.1 && transform.position.y>-1.6 && transform.position.x<0.07 && transform.position.x>-0.07)
        {
            transform.position = v;
            rend.material.SetFloat("_Metallic",0.45f);
            rend.material.color = Color.Lerp(Color.black, Color.white, 0f);
            c = false;
            
            if(Input.GetAxisRaw("Mouse ScrollWheel")>0f)
            {
                s.transform.localScale += new Vector3(30f, 30f, 30f);
                t.transform.localScale += new Vector3(5f, 5f, 5f);
            }
            else if(Input.GetAxisRaw("Mouse ScrollWheel") < 0f && s.transform.localScale.x > 100f)
            {
                    s.transform.localScale -= new Vector3(30f, 30f, 30f);
                    t.transform.localScale -= new Vector3(5f, 5f, 5f);
            }
            if(s.transform.localScale.x>1500f)
            {
                LoadNextLevel();
            }
            
        }
        rend.material.color = Color.Lerp(Color.black, Color.white, a);
    }
    void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
