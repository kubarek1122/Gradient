using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;
    private static bool i=false;

    void Update()
    {
        i = scene6move.jest;
        if (i)
        {
            LoadNextLevel();
        }
    }
    void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
            StartCoroutine(LoadLevel(0));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("S");
        yield return new WaitForSeconds(transitionTime);
        Application.Quit();
    }
}
