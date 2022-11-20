using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : Singleton<MenuUI>
{
    public GameController gameController;

    public GameObject howToPlay;
    public GameObject victoryWindow;
    private GameObject mainMenu;

    protected override void Awake()
    {
        //gameController = transform.parent.GetComponent<GameController>();
        //howToPlay = transform.Find("HowToPlay").gameObject;
        //victoryWindow = transform.Find("VictoryWindowUI").gameObject;
        mainMenu = transform.Find("MainMenuUI").gameObject;
    }

    public void OnClickStart()
    {
        SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Additive);
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
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ToggleVictoryWindow(bool v)
    {
        victoryWindow.SetActive(v);
    }

    public void LoadGameScene()
    {
        //gameController.LoadGameScene();
    }

    public void ToggleMainMenu(bool v)
    {
        mainMenu.SetActive(v);
    }
}
