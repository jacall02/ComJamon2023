using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanderaValencia : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<FallenObject>().Fall();
        }
    }
}
