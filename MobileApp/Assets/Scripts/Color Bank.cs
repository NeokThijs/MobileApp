using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorBank : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Material[] Color;
    private byte currentColor = 0;
    private void NextColor()
    {
        currentColor++;
        if (currentColor >= Color.Length)
        {
            currentColor = 0;
        }
        gameObject.GetComponent<Renderer>().material = Color[currentColor];
        
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        NextColor();
    }
}
