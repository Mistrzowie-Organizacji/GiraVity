using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryWindow : MonoBehaviour
{ 

    [SerializeField] private GameObject mainMenu;

    public void OnClickDoneButton()
    {
        mainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
