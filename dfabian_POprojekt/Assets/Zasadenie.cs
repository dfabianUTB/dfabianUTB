using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zasadenie : MonoBehaviour
{

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Seed"))
        {
            Debug.Log("Vyhral si! Koniec hry.");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
