
using TMPro;
using UnityEngine;
using YG;


public class InternationalText : MonoBehaviour
{
    [SerializeField] string _en;
    [SerializeField] string _ru;
    [SerializeField] string _tr;


    private void Start()
    {
        if (YandexGame.EnvironmentData.language == "en")
        {
            GetComponent<TextMeshProUGUI>().text = _en;
        }
        else if (YandexGame.EnvironmentData.language == "ru")
        {
            GetComponent<TextMeshProUGUI>().text = _ru;
        }
        else if (YandexGame.EnvironmentData.language == "tr")
        {
            GetComponent<TextMeshProUGUI>().text = _tr;
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = _en;
        }
    }



}