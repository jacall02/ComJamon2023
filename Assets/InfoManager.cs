using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    public static InfoManager instance; // singleton instance of the GameManager

    public struct Info
    {
        public string name;
    }

    private Info info;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); // don't destroy the GameManager object when a new scene is loaded
            DOTween.Init(true, true);
            info.name = "Usuario";
        }
        else
        {
            Destroy(this.gameObject); // if an instance already exists, destroy this one
        }
        
    }

    public Info getInfo()
    {
        return info;
    }

    public void SetPlayerName(string s)
    {
        info.name = s;
    }
}
