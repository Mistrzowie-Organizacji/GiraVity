using UnityEngine;

public class VictoryWindow : MonoBehaviour
{

    [SerializeField] private GameObject mainMenu;

    public void OnClickDoneButton()
    {
        mainMenu.SetActive(true);
        GameController.Instance.GoBackToMainMenu();
        gameObject.SetActive(false);
    }
}
