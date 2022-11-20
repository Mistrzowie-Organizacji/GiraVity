using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuUI : MonoBehaviour
{
    private GameObject howToPlay;
    string gameSceneName = "SampleScene";
    string mainMenuSceneName = "MainMenuScene";
    private void Awake()
    {
        howToPlay =  transform.Find("HowToPlay").gameObject;
    }
    public void OnClickStart()
    {
        SceneManager.UnloadSceneAsync(mainMenuSceneName);
        SceneManager.LoadSceneAsync(gameSceneName);
    }

    public void OnClickOpenHowToPlay()
    {
        howToPlay.SetActive(true);

    }
    public void OnClickCloseHowToPlay()
    {
        howToPlay.SetActive(false);

    }
    public void OnClickExit()
    {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }


}
