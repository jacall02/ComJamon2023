using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GetPlayerName : MonoBehaviour
{

    [SerializeField]
    private int charLimit = 16;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        if(text != null)
        {
            string s = InfoManager.instance.getInfo().name;
            if(s.Length > charLimit)
            {
                s = s.Substring(0, charLimit);
            }

            text.text = s;
        }
    }

    
}
