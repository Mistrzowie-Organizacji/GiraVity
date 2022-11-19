using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuStartButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Sprite buttonPointerUpSprite;
    [SerializeField] private Sprite buttonPointerDownSprite;
    private Image buttonSprite;
    int easingID = -1;
    void Start()
    {
        buttonSprite = transform.GetComponent<Image>();
    }
    
    [SerializeField] private GameObject girrafeSprite;
    Vector3 girrafeStartingPosition = new Vector3(300, -600);
    Vector3 girrafeOnButtonPosition = new Vector3(300, -150);

    public void OnPointerEnter(PointerEventData eventData)
    {

        LeanTween.cancel(girrafeSprite);

        if (!LeanTween.isTweening(easingID))
        easingID = LeanTween.moveLocal(girrafeSprite, girrafeOnButtonPosition,1f).uniqueId;
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        
        LeanTween.moveLocal(girrafeSprite, girrafeStartingPosition,1f);
        

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
