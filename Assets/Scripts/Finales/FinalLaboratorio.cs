using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLaboratorio : Final
{
    [SerializeField] private int nClicks = 30;
    [SerializeField] private string herramienta = "Destornillador";
    [SerializeField] private GameObject lata;
    private bool lataActivada = false;


    private void Awake()
    {
        ID = IDFinales.Laboratorio;
    }

    private void Update()
    {
        if (!lataActivada && GameManager.instance.Submits >= nClicks)
        {
            lataActivada = true;
            lata.transform.DOLocalMoveY(0.0f, 2.0f).SetEase(Ease.OutBounce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == herramienta)
        {
            collision.GetComponent<ClickableDrag>().SetRestartPosition(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == herramienta)
        {
            collision.GetComponent<ClickableDrag>().SetRestartPosition(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        // Cuando se pulse la lata con la herramienta adecuada
        if (Input.GetMouseButton(0))
        {
            if (collision.gameObject.tag == herramienta)
            {

            }
        }
        //si el objeto que choca el collider es un destornillador

    }

}
