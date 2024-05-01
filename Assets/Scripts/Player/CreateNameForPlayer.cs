using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateNameForPlayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _InputText;
    [SerializeField] private InputField _InputLegTex;

    private void OnEnable() => YandexGame.GetDataEvent += Loading;

    private void OnDisable() => YandexGame.GetDataEvent -= Loading;

    private void Start()
    {
        if(YandexGame.SDKEnabled == true)
        {
            Loading();
        }
    }
    public void InputName()
    {
        string InputText = _InputLegTex.text;
        _InputText.text = InputText;
        Saveing(InputText);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    private void Loading()
    {
        _InputText.text = YandexGame.savesData.PlayerName;
    }

    private void Saveing(string Name)
    {
        YandexGame.savesData.PlayerName = Name;
        YandexGame.SaveProgress();
    }
}
