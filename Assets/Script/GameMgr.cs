using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{

    public bool winLose;
    public string lifeSave;
    public bool isPaused;

    private const string SAVE_LIFE = "LIFE";

    private static GameMgr instance;

    public static GameMgr getInstance()
    {
        if (instance is null)
        {
            instance = new GameMgr();
        }
        return instance;
    }

    protected virtual string GetSaveLife()
    {
        return GameMgr.SAVE_LIFE;
    }

    public virtual void LoadSaveLife()
    {
        if(PlayerPrefs.GetString(this.GetSaveLife()) == "")
        {
            PlayerPrefs.SetString(this.GetSaveLife(), "3");
            lifeSave = PlayerPrefs.GetString(this.GetSaveLife());
        }
        else
        {
            lifeSave = PlayerPrefs.GetString(this.GetSaveLife());
        }
    }

    public virtual void SaveLife(string life)
    {
        Debug.Log($"SaveGame");
        PlayerPrefs.SetString(this.GetSaveLife(), life);
    }
}
