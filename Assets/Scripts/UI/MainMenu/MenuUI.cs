using System;
using UnityEngine;


public class MenuUI : Singleton<MenuUI>
{
    private GameController gameController;

    private GameObject howToPlay;
    private GameObject victoryWindow;
    private GameObject mainMenu;

    protected override void Awake()
    {
        gameController = transform.parent.GetComponent<GameController>();
        howToPlay = transform.Find("HowToPlay").gameObject;
        victoryWindow = transform.Find("VictoryWindowUI").gameObject;
        mainMenu = transform.Find("MainMenu").gameObject;
    }

    public void OnClickStart()
    {
        gameController.LoadGameScene();
        gameController.isGameActive = true;
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

    public void ToggleVictoryWindow(bool v)
    {
        victoryWindow.SetActive(v);
    }

    public void LoadGameScene()
    {
        gameController.LoadGameScene();
    }

    public void ToggleMainMenu(bool v)
    {
        mainMenu.SetActive(v);
    }
}
