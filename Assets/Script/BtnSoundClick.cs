using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSoundClick : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip onClickBtn;

    public void OnClickSound(){
        mySound.PlayOneShot(onClickBtn);
    }
}
