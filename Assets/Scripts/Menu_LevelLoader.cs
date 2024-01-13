using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;
    private static bool i;

    void Update()
    {
        i = Menu.jest;
        if (i)
        {
            LoadNextLevel();
        }
    }
    void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            StartCoroutine(LoadLevel("1"));
    }
    IEnumerator LoadLevel(string levelIndex)
    {
        transition.SetTrigger("S");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
