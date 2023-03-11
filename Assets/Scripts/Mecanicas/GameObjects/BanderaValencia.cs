using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanderaValencia : MonoBehaviour
{
    [SerializeField]
    private Collider2D[] tornillos;

    private void Start()
    {
        foreach (Collider2D c in tornillos)
        {
            c.enabled = false;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<FallenObject>().Fall();
            foreach(Collider2D c in tornillos)
            {
                c.enabled = true;
            }
        }
    }


}
