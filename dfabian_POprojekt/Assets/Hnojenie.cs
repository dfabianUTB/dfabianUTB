using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hnojenie : MonoBehaviour
{

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Seed"))
        {
            Destroy(gameObject);
            c2d.transform.localScale += new Vector3 (0.05f,0.02f,0);
        }
    }
}
