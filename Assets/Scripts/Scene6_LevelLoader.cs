using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene6_LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;
    private static bool i;

    void Update()
    {
       
        i = scene6load.jest; 
        Debug.Log(i);
        if (i)
        {
            LoadNextLevel();
        }
    }
    void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().name == "5")
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
