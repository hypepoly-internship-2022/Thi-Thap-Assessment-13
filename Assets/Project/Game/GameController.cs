using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class GameController : Controller
{
    public const string GAME_SCENE_NAME = "Game";

    public override string SceneName()
    {
        return GAME_SCENE_NAME;
    }
    public void OnScoreButtonClick()
    {
        Manager.Add(ScorePopupController.SCOREPOPUP_SCENE_NAME, "ScorePopup");
        Debug.Log("?");
    }

    public void OnSettingsButtonTap()
    {
        Manager.Add(PausePopupController.PAUSEPOPUP_SCENE_NAME, "PausePopup");
        Debug.Log("?");
    }
    public void OnResumButtonTap()
    {
        Manager.Load(GameController.GAME_SCENE_NAME);
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