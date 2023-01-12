using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using System;

public class HomeController : Controller
{
    public const string HOME_SCENE_NAME = "Home";

    public override string SceneName()
    {
        return HOME_SCENE_NAME;
    }

    public void OnVoteButtonTap()
    {
        Manager.Add(VotePopupController.VOTEPOPUP_SCENE_NAME, "VotePopup");
    }

    public void OnSettingsButtonTap()
    {
        Manager.Add(SettingsPopupController.SETTINGSPOPUP_SCENE_NAME, "SettingsPopup");
    }

    public void OnPlayButtonTap()
    {
        if(Int32.Parse(GameMgr.getInstance().lifeSave) <= 0)
        {
            Manager.Add(HeartPopupController.HEARTPOPUP_SCENE_NAME, "HeartPopup");
        }
        else
        {
            int lifeCount = Int32.Parse(GameMgr.getInstance().lifeSave) - 1;
            GameMgr.getInstance().SaveLife(lifeCount.ToString());
            Manager.Load(GameController.GAME_SCENE_NAME, "Game");
        }
    }
}