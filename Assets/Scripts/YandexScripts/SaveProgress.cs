using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class SaveProgress : MonoBehaviour
{

    [SerializeField] Bird _bird;

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;



    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }




    public void GetLoad()
    {
        _bird._scoreMaxInt = YandexGame.savesData._maxScore;
    }

    public void MySave()
    {
        YandexGame.savesData._maxScore  = _bird._scoreMaxInt;
        YandexGame.SaveProgress();
    }

}
