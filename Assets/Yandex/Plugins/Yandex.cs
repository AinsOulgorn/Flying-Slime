using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Hello();


    [DllImport("__Internal")]
    private static extern void SetPlayerData();


    [DllImport("__Internal")]
    private static extern void RateGame();



    [SerializeField] TextMeshProUGUI _namePlayer;
    [SerializeField] RawImage _photoPlayer;

    public void SetData()
    {
        SetPlayerData();
    }



    public void RateGameButton()
    {
        RateGame();
    }


    public void SetName(string name)
    {
        _namePlayer.text = name;
    }


    public void SetPhoto(string url)
    {
        StartCoroutine(DownloadImage(url));
    }

    IEnumerator DownloadImage(string mediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(mediaUrl);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log(request.error);
        }
        else
        {
            _photoPlayer.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
        }





    }









}
