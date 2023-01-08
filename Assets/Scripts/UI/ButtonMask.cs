using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




[RequireComponent(typeof(Image))]
public class ButtonMask : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField] float _alphaLevel = 1f;
    private Image _imageButton;


    private void Start()
    {
        _imageButton = gameObject.GetComponent<Image>();
        _imageButton.alphaHitTestMinimumThreshold= _alphaLevel;
    }


}
