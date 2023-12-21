using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSquare : MonoBehaviour
{
    public float hiz = 5f; // Karakterin hareket hızı


    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        float dikeyInput = Input.GetAxis("Vertical");

        float yatayInput = Input.GetAxis("Horizontal"); // "Horizontal" eksenindeki klavye girişini al

        Vector3 hareket = new Vector3(yatayInput, dikeyInput, 0f); // Hareket vektörü oluştur

        transform.position += hareket * hiz * Time.deltaTime; // Hareketi uygula

    }
}


