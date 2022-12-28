using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;

    public override void Close()
    {
       // _canvasGroup.alpha = 0;
       // _button.interactable = false;
        _buttonFly.SetActive(true);
        _buttonStartEnd.SetActive(false);
        _screen.SetActive(false);
        _slimePush.SetActive(true);
    }

    public override void Open()
    {
       // _canvasGroup.alpha = 1;
       // _button.interactable = true;
        _buttonFly.SetActive(false);
        _buttonStartEnd.SetActive(true);
        _screen.SetActive(true);
        _slimePush.SetActive(false);
    }

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke(); 
    }
}

