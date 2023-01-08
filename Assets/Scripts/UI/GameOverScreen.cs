using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;


public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;


    [DllImport("__Internal")]
    private static extern void ShowAdv();


    [DllImport("__Internal")]
    private static extern void SetToLeaderboard(int value);

    public override void Close()
    {
       // _canvasGroup.alpha = 0;
       // _button.interactable = false;
       _score.SetActive(true);
        _buttonFly.SetActive(true);
        _buttonStartEnd.SetActive(false);
        _screen.SetActive(false);
        _slimePush.SetActive(true);

    }

    public override void Open()
    {

        ShowAdv();
       // _canvasGroup.alpha = 1;
       // _button.interactable = true;
       _score.SetActive(false);
        _buttonFly.SetActive(false);
        _buttonStartEnd.SetActive(true);
        _screen.SetActive(true);
        _slimePush.SetActive(false);
        _scoreInt.text = _bird._score.ToString();
        

        if (_bird._score >_bird._scoreMaxInt)
        {
            _scoreMax.text= _bird._score.ToString();
            _bird._scoreMaxInt = _bird._score;
            Progress.Instance.PlayerInfo._record = _bird._scoreMaxInt;
            Progress.Instance.Save();
            
        }
        else
        {
            _scoreMax.text = _bird._scoreMaxInt.ToString();
        }


        SetToLeaderboard(Progress.Instance.PlayerInfo._record);
    }

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke(); 
    }
}

