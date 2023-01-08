using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class Language : MonoBehaviour
{

    [DllImport("__Internal")]

    private static extern string GetLang();




    public string _currentLanguage; // ru en tu

    public static Language Instance;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _currentLanguage = GetLang();

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
