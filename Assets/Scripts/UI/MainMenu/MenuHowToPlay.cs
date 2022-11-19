using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuHowToPlay : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Sprite buttonPointerUpSprite;
    [SerializeField] private Sprite buttonPointerDownSprite;
    private Image buttonSprite;
    void Start()
    {
        buttonSprite = transform.GetComponent<Image>();
    }

    [SerializeField] private GameObject girrafeSprite;
    Vector3 girrafeStartingPosition = new Vector3(300, -600);
    Vector3 girrafeOnButtonPosition = new Vector3(300, -305);

    public void OnPointerEnter(PointerEventData eventData)
    {
        girrafeSprite.transform.localPosition = girrafeOnButtonPosition;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        girrafeSprite.transform.localPosition = girrafeStartingPosition;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonSprite.sprite = buttonPointerDownSprite;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonSprite.sprite = buttonPointerUpSprite;
    }
}
