using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{

    [SerializeField] private GameObject[] star = new GameObject[3];

    private Image star1;
    private Image star2;
    private Image star3;
    void Start()
    {
        star1 = star[0].GetComponent<Image>();
        star2 = star[1].GetComponent<Image>();
        star3 = star[2].GetComponent<Image>();

        showStar();
    }

    private void showStar()
    {
        if(GameMgr.getInstance().winLose == true)
        {
            star1.color = Color.white;
            star2.color = Color.white;
            star3.color = Color.white;
            GameMgr.getInstance().winLose = false;
        }
    }
}
