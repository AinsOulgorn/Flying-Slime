using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Screen : MonoBehaviour
{
    //[SerializeField] protected CanvasGroup _canvasGroup;
    [SerializeField] protected Button _button;
    [SerializeField] protected CanvasGroup _scoreCanvasGroup;
    [SerializeField] protected GameObject _buttonFly;
    [SerializeField] protected GameObject _buttonStartEnd; 
    [SerializeField] protected GameObject _screen;
    [SerializeField] protected GameObject _slimePush;



    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }


    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();

    public abstract void Open();

    public abstract void Close();

}
