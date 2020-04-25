using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverDisplayObj : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private GameObject _objectDisplay;

    // Start is called before the first frame update
    void Start()
    {
        _objectDisplay.SetActive(false);
    }

    // display game object if button hovered over
    public void OnPointerEnter(PointerEventData eventData)
    {
        _objectDisplay.SetActive(true);
    }

    // disable game object if player no longer hovering over button
    public void OnPointerExit(PointerEventData eventData)
    {
        _objectDisplay.SetActive(false);
    }
}
