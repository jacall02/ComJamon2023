using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLaboratorio : Final
{
    [SerializeField] private AnimacionAlerta canvasAnimacion;
    [SerializeField] private int nClicks = 30;
    [SerializeField] private string herramienta = "Destornillador";
    [SerializeField] private GameObject lata;
    [SerializeField]
    private GameObject volumneEffectDSI;

    [SerializeField]
    private SpriteSwapper camaraSprite;

    [SerializeField]
    private GameObject banScreen;
    private bool lataActivada = false;
    private bool sonido = false;


    private void Awake()
    {
        ID = IDFinales.Laboratorio;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.PlayEffect(2, 1f);
            sonido = true;
            //activamos plagio screen
            banScreen.SetActive(true);
            //VOLUMEN DE DSI
            volumneEffectDSI.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
            // Final conseguido
            desactivador.ActivarNota(ID);

            canvasAnimacion.enabled = true;
        }
    }

    private void Update()
    {
        if (!lataActivada && GameManager.instance.Submits >= nClicks)
        {
            lataActivada = true;
            lata.transform.DOLocalMoveY(0.0f, 2.0f).SetEase(Ease.OutBounce);
            camaraSprite.SwapSprite();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destornillador")
        {
            collision.GetComponent<ClickableDrag>().SetRestartPosition(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destornillador")
        {
            collision.GetComponent<ClickableDrag>().SetRestartPosition(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!sonido && Input.GetMouseButton(0))
        {
            if (collision.gameObject.tag == herramienta)
            {
                collision.GetComponent<ClickableDrag>().SetRestartPosition(true);
                collision.GetComponent<ClickableDrag>().ResetPosition();

                SoundManager.instance.PlayEffect(2, 1f);
                sonido = true;
                Invoke("SonidoAlarma", 1f);
                
                //sonido alarma
                //VOLUMEN DE DSI
                volumneEffectDSI.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
                // Final conseguido
                desactivador.ActivarNota(ID);

                canvasAnimacion.enabled = true;
            }
        }
    }

    private void SonidoAlarma()
    {
        SoundManager.instance.PlayEffect(19, 1f);
    }

}
