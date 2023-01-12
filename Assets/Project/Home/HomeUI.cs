using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class HomeUI : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI heartText;

    private void Awake()
    {
        GameMgr.getInstance();
    }

    private void Start()
    {
        GameMgr.getInstance().LoadSaveLife(); 
        heartText.GetComponent<TextMeshProUGUI>().text = GameMgr.getInstance().lifeSave;
    }

}
