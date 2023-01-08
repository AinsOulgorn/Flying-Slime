using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] protected GameObject _score;
    [SerializeField] protected Bird _bird;
    [SerializeField] protected TMP_Text _scoreInt;
    [SerializeField] protected TMP_Text _scoreMax;




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
