using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using UnityEngine.UI;

public class MainController : Controller
{

    [SerializeField] private Slider slider;

    public const string MAIN_SCENE_NAME = "Main";

    public override string SceneName()
    {
        return MAIN_SCENE_NAME;
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);

        Manager.LoadingSceneName = HomeController.HOME_SCENE_NAME;
        Manager.Load(HomeController.HOME_SCENE_NAME);
    }
}