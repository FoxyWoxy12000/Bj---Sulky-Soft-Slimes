using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public GameObject LoseScreen;

    void Start()
    {
        Time.timeScale = 1;
        LoseScreen.SetActive(false);
    }
    public void YouLoser()
    {
        //Time.timeScale = 0;
        LoseScreen.SetActive(true);
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
