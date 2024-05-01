using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class TomControl : MonoBehaviour
{
    private void OnEnable() => YandexGame.GetDataEvent += Loading;

    private void OnDisable() => YandexGame.GetDataEvent -= Loading;

    public List<string> Pages = new List<string>();

    public string Name;

    public int NumberPage = 0;

    private string _playerName;

    private void Start()
    {
        Pages[30] = _playerName + " - зеленоглазая девушка 17 - ти лет с короткими русыми волосами до плеч, маленького роста и небольшого телосложения.";
        InfoPage();
    }
    public void InfoPage()
    {
        Debug.Log("reloaded");
        if(NumberPage is 0 or 1 or  2 or 3 or 4 or 5 or 6 or 7 or 8 or 9 or 10 or 11 or 12 or 13 or 14 or 15 or 16 or 28 or 30 or 33 or 34 or 35 or 36 or 37 or 38 or 39 or 40 or 41 or 42 or 43 or 44 or 45 or 46 or 47 or 49 or 50 or 52 or 62 or 63 or 66 or 67 or 73 or 78 or 81 or 82 or 83 or 84 or 85 or 86 or 87)
        {
            Name = "...";
        }
        if(NumberPage is 18 or 20 or 22 or 24 or 26 or 29)
        {
            Name = "Мама";
        }
        if(NumberPage is 17 or 19 or 21 or 23 or 25 or 27 or 31 or 48 or 54 or 56 or 58 or 60 or 69 or 71 or 80)
        {
            Name = _playerName;
        }
        if(NumberPage is 32 or 51 or 53 or 55 or 57 or 59 or 61 or 64 or 68 or 70 or 76 or 79)
        {
            Name = "Лем";
        }
        if(NumberPage is 72)
        {
            Name = "Лем в мыслях"
        }
        if(NumberPage is 65 or 74 or 75 or 77)
        {
            Name = "Элизабет";
        }
    }

    private void Loading()
    {
        _playerName = YandexGame.savesData.PlayerName;
    }
}
