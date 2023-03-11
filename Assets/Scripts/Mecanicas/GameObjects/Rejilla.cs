using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejilla : MonoBehaviour
{
    public void RestarTornillo()
    {
        if(GetComponentsInChildren<Tornillo>().Length == 0)
        {
            GetComponent<FallenObject>().Fall();
        }
    }
}
