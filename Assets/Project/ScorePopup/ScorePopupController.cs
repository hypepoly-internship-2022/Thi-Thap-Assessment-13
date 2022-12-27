using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using TMPro;

public class ScorePopupController : Controller
{
    public const string SCOREPOPUP_SCENE_NAME = "ScorePopup";
    int starNumber;
    [SerializeField] GameObject stars;
    [SerializeField] TextMeshProUGUI ribbonText;
    public override string SceneName()
    {
        return SCOREPOPUP_SCENE_NAME;
    }
    public void OnScoreButtonClick()
    {
        Manager.Add(ScorePopupController.SCOREPOPUP_SCENE_NAME, "ScorePopup");
        Debug.Log("?");
    }
    public override void OnActive(object data = null)
    {
        if (data != null)
        {
            starNumber = int.Parse(data.ToString());
        }
        StartGenerateStar(starNumber);
    }
    void StartGenerateStar(int starNumber)
    {
        if(starNumber == 0)
        {
            SetUpText();
        }
        for (int i = 0; i < starNumber; i++)
        {
           stars.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
    void SetUpText()
    {
        ribbonText.text = "You Lose";
    }
}