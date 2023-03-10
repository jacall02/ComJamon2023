using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomName : MonoBehaviour
{
    [SerializeField]
    string[] fileNames;

    //[SerializeField]
    //TextMesh text;

    private TextMeshProUGUI text_;

    private void Start()
    {
        text_ = GetComponent<TextMeshProUGUI>();
        ChangeName();
    }

    public void ChangeName()
    {
        if(text_ != null)
        {
            text_.text = GetRandomFileName();
        }
        ////El n?mero de intentos va asociado al nombre del cpp, lo reseteamos
        //GameManager.instance.ResetSubmits();
    }

    public string GetRandomFileName()
    {
        return fileNames[Random.Range(0, fileNames.Length)];
    }
}
