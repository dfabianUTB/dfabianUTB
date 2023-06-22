using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmrtPascou : MonoBehaviour
{

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Seed"))
        {
            Debug.Log("Zomrel si! Koniec hry.");
            Destroy(c2d.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
