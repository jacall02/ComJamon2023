using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarImagen : MonoBehaviour
{
    [SerializeField] GameObject foto;
    [SerializeField] Sprite sprite;

    public void MoveImage()
    {
        foto.transform.DOLocalMove(new Vector3(-13.30f, 0.6f, 1.4f), 0.0f);
        foto.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
