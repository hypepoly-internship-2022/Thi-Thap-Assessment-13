using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadingBar : MonoBehaviour
{

    [SerializeField] private float speedRunBar;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI loadingText;

    private float value = 1;

    private void Start()
    {
        StartCoroutine(percentBar());
    }

    private void Update()
    {
        runBar();
    }

    private IEnumerator percentBar()
    {
        for (int i = 0; i < speedRunBar; i++)
        {
            value = i / speedRunBar;
            loadingText.text = ((value * 100f) + 1).ToString("f0") + "%";

            yield return null;
        }
    }

    private void runBar ()
    {
        slider.value = value;
    }
}
