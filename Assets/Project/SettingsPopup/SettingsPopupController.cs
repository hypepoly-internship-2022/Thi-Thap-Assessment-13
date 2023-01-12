using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class SettingsPopupController : Controller
{
    public const string SETTINGSPOPUP_SCENE_NAME = "SettingsPopup";

    public override string SceneName()
    {
        return SETTINGSPOPUP_SCENE_NAME;
    }
}