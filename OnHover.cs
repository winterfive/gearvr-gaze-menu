using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class OnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

    public Image image;

    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image> ();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverExit();
    }

    void OnHoverEnter()
    {
        image.color = Color.magenta;
    }

    void OnHoverExit()
    {
        image.color = Color.black;
    }

    void OnClick()
    {
        image.color = Color.green;
    }    
}
