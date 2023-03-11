using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesactivadorBotones : MonoBehaviour
{
    // Botones que se bloquean cuando consigues un final
    [SerializeField] private List<Button> buttons;
    [SerializeField] private List<SpriteRenderer> notas;

    public void Start()
    {
        bool[] finales = GameManager.instance.GetFinales;

        for (int i = 0; i < finales.Length; ++i)
        {
            if (finales[i])
            {
                notas[i].enabled = true;
            }
        }
    }
    public void DesactivarTodo()
    {
        foreach (Button b in buttons)
        {
            if (b != null)
                b.interactable = false;
        }
    }

    public void ActivarNota(int i)
    {
        notas[i].enabled = true;
    }
}
