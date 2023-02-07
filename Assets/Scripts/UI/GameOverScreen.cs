using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using YG;

public class GameOverScreen : ScreenGame
{
    public event UnityAction RestartButtonClick;



    public override void Close()
    {
       _score.SetActive(true);
        _buttonFly.SetActive(true);
        _buttonStartEnd.SetActive(false);
        _screen.SetActive(false);
        _slimePush.SetActive(true);

    }

    public override void Open()
    {
        YandexGame.FullscreenShow();
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
            YandexGame.NewLeaderboardScores("score", _bird._scoreMaxInt);
            _saveProgress.MySave();
            
        }
        else
        {
            _scoreMax.text = _bird._scoreMaxInt.ToString();
        }
    }

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke(); 
    }
}

