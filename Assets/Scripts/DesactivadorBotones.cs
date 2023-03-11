using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesactivadorBotones : MonoBehaviour
{
    // Botones que se bloquean cuando consigues un final
    [SerializeField] private List<Button> buttons;
    [SerializeField] private List<SpriteRenderer> notas;
    [SerializeField] private List<FallenObject> objetosQueCaen;
    [SerializeField] private List<ClickableDrag> herramientas;

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

        foreach (FallenObject b in objetosQueCaen)
        {
            if (b != null)
                b.enabled = true;
        }

        foreach (Button b in buttons)
        {
            if (b != null)
                b.interactable = true;
        }

        foreach (ClickableDrag b in herramientas)
        {
            if (b != null)
                b.enabled = true;
        }
    }
    public void DesactivarTodo()
    {
        foreach (FallenObject b in objetosQueCaen)
        {
            if (b != null)
                b.enabled = false;
        }

        foreach (Button b in buttons)
        {
            if (b != null)
                b.interactable = false;
        }

        foreach (ClickableDrag b in herramientas)
        {
            if (b != null)
                b.enabled = false;
        }
    }

    public void ActivarNota(IDFinales i)
    {
        DesactivarTodo();
        GameManager.instance.ConseguirFinal(i);
        notas[(int)i].enabled = true;
    }
}
