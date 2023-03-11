using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesactivadorBotones : MonoBehaviour
{
    // Botones que se bloquean cuando consigues un final
    [SerializeField] private List<Button> buttons;

    public void DesactivarTodo()
    {
        foreach (Button b in buttons)
        {
            if (b != null)
                b.interactable = false;
        }
    }
}
