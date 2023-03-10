using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObject : MonoBehaviour
{

    public void Fall()
    {
        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
}
