using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UiSystem : MonoBehaviour
{
    float zaman = 0f;
    public TMP_Text zText;
    public TMP_Text eskikayit;
    // Start is called before the first frame update
    void Start()
    {
        eskikayit.text = "Last Score: "+ PlayerPrefs.GetInt("Eski Kayit", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        zText.text = " " + (int)zaman;

        PlayerPrefs.SetInt("Eski Kayit", (int)zaman);
    }


}
    




