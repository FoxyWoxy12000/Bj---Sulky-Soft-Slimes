using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWIn : MonoBehaviour
{
    public GameObject WeenScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        WeenScreen.SetActive(false);
    }

    // Update is called once per frame
    public void YouWEEEEN()
    {
        Time.timeScale = 0;
        WeenScreen.SetActive(true);
    }
    public void AgainRetry()
    {
        SceneManager.LoadScene(0);
    }
}
