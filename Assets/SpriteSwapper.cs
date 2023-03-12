using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite Actual;
    [SerializeField]
    Sprite Swapped;

    private void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Actual;
    }

    public void SwapSprite()
    {
        spriteRenderer.sprite = Swapped;
    }
}
