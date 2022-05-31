using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    public Text textCompnent;
    public AudioSource audioSource;

    private void Start()
    {
        Screen.SetResolution(1920,1080,false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
   
    public void AddcoinCount()
    {
        coinCount += 1;
        Debug.Log("CoinCount:" + coinCount);
        textCompnent.text = "CoinCoount : " + coinCount;
        audioSource.Play();
    }
}
