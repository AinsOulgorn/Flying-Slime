using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;




[System.Serializable]
public class PlayerInfo
{
    public int _record;
}

public class Progress : MonoBehaviour
{
    public PlayerInfo PlayerInfo;


    [DllImport("__Internal")]
    
    private static extern void SaveExtern(string date);


    [DllImport("__Internal")]
    private static extern void loadExtern();



    [SerializeField] private TextMeshProUGUI _playerInfoText;




    public static Progress Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
            loadExtern();
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        SaveExtern(jsonString);
    }

    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
    }

}
