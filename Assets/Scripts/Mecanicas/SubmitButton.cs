using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitButton : MonoBehaviour
{
    [SerializeField]
    private CajonComportamiento CajonComportamiento;

    [SerializeField]
    private int numeroSubmitsAbrirCajon = 5;

    public void AddOneSubmit()
    {
        int i = GameManager.instance.Submit();
        if (i == numeroSubmitsAbrirCajon)
        {
            CajonComportamiento.AbrirCajon();
        }
    }
}
