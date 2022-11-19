using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MenuUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private GameObject howToPlay;
    private bool isPressedButton;
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

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressedButton = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressedButton = false;
    }
    public void changeGirraffeHeight()
    {
        
    }
}
