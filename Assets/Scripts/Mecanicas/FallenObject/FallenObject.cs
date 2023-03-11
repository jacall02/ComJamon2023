using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObject : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    public void Fall()
    {
        //this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        this.GetComponent<Rigidbody2D>().gravityScale = 1;
        Invoke("DestroyThisObject", 5f);
    }

    private void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }
}
