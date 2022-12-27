using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using TMPro;
using System;

public class HeartPopupController : Controller
{
    public const string HEARTPOPUP_SCENE_NAME = "HeartPopup";
     int starNumber;
    [SerializeField] GameObject stars;
    [SerializeField] TextMeshProUGUI ribbonText;
    [SerializeField] TextMeshProUGUI congrateText;
    [SerializeField] TextMeshProUGUI scoreText;
    public override string SceneName()
    {
        return HEARTPOPUP_SCENE_NAME;
    }

    public void OnYButtonTap()
    {
        int lifeCount = Int32.Parse(GameMgr.getInstance().lifeSave) + 5;
        GameMgr.getInstance().SaveLife(lifeCount.ToString());
        StartCoroutine(LoadingToHome());
    }

    IEnumerator LoadingToHome()
    {
        Manager.LoadingAnimation(true);

        yield return new WaitForSeconds(0.5f);

        Manager.LoadingAnimation(false);

        Manager.Load(HomeController.HOME_SCENE_NAME);
    }
}
// public void OnHomeButtonClick()
//     {
//         Manager.Load(HomeController.HOME_SCENE_NAME);
//     }
//     public void OnVoteButtonClick()
//     {
//         Manager.Add(VotePopupController.VOTEPOPUP_SCENE_NAME);
//     }
//     public override void OnActive(object data = null)
//     {
//         if (data != null)
//         {
//             starNumber = int.Parse(data.ToString());
//         }
//         StartGenerateStar(starNumber);
//     }
//     void StartGenerateStar(int starNumber)
//     {
//         if(starNumber == 0)
//         {
//             SetUpText();
//         }
//         for (int i = 0; i < starNumber; i++)
//         {
//            stars.gameObject.transform.GetChild(i).gameObject.SetActive(true);
//         }
//     }
//     void SetUpText()
//     {
//         ribbonText.text = "You Lose";
//         scoreText.text = "0";
//         congrateText.text = "Better Luck Next Time";
//     }
// }