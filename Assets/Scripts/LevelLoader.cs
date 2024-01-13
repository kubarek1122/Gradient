using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;
    private static bool i;
 
    void Update()
    {
        i = PlayerController.jest;
        if(i)
        {
            LoadNextLevel();
        }
    }
    void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex==1)
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
