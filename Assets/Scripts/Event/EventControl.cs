using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class EventControl : MonoBehaviour
{
    [SerializeField] private GameObject _tom1, _tom2, _tom3;

    [SerializeField] private TMP_Text _Text, _TextName;

    [SerializeField] private float _delay = 0.04f;

    [SerializeField] private string _thisTxt;

    private bool _btom1 = true, _btom2, _btom3;

    [SerializeField] private int ClickCount = 1;

    private void Start()
    {
        if(_btom1 == true)
        {
            _TextName.text = _tom1.GetComponent<TomControl>().Name;
            _Text.text = "";
            int number = _tom1.GetComponent<TomControl>().NumberPage;
            _thisTxt = _tom1.GetComponent<TomControl>().Pages[number];
            StartCoroutine(PrintTxt(_thisTxt));
        }
    }
    public void OnClick()
    {
        ClickCount++;
        if(ClickCount == 2)
        {
            _Text.text = "";
            StopAllCoroutines();
            _Text.text = _thisTxt;
        }
        if(ClickCount == 3)
        {
            _tom1.GetComponent<TomControl>().NumberPage++;
            _tom1.GetComponent<TomControl>().InfoPage();
            _TextName.text = _tom1.GetComponent<TomControl>().Name;
            _Text.text = "";
            int number = _tom1.GetComponent<TomControl>().NumberPage;
            _thisTxt = _tom1.GetComponent<TomControl>().Pages[number];
            StartCoroutine(PrintTxt(_thisTxt));
            ClickCount = 1;
        }
    }
    IEnumerator PrintTxt(string txt)
    {
        
        foreach (var sym in txt)
        {
            _Text.text += sym;
            yield return new WaitForSeconds(_delay); 
            if(_Text.text == txt)
            {
                ClickCount++;
            }

        }
    }

}
