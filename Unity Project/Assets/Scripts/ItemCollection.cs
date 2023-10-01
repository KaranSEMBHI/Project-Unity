using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    private int Bananas = 0;
    [SerializeField] private Text BananasText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Banana"))
        {
            Destroy(other.gameObject);
            Bananas++;
            BananasText.text = "Bananas: " + Bananas;
        }
    }
}


