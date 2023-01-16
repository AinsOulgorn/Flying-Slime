using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : ScreenGame
{
    public event UnityAction PlayButtonClick;

    public override void Close()
    {
        // _canvasGroup.alpha = 0;
        // _button.interactable = false;
        _scoreCanvasGroup.alpha = 1;
        _buttonFly.SetActive(true);
        _buttonStartEnd.SetActive(false);
        _screen.SetActive(false);
        _slimePush.SetActive(true);

    }

    public override void Open()
    {
        // _canvasGroup.alpha = 1;
        // _button.interactable = true;
        _scoreCanvasGroup.alpha = 0;
        _buttonFly.SetActive(false);
        _buttonStartEnd.SetActive(true);
        _screen.SetActive(true);
        _slimePush.SetActive(false);
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }
}
