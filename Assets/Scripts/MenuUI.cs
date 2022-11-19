using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuUI : MonoBehaviour
{
    private GameObject howToPlay;

    private void Awake()
    {
        howToPlay =  transform.Find("HowToPlay").gameObject;
    }
    public void OnClickStart()
    {

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
    }
}
