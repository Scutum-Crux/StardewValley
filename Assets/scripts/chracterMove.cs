//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class chracterMove : MonoBehaviour
//{
//    [SerializeField] private float speed = 3.0f;// Karakterin hareket hızı 

//    private Vector2 movement;
//    private SpriteRenderer spriteRenderer;
//    void Start()
//    {
//        // SpriteRenderer bileşenini al
//        spriteRenderer = GetComponent<SpriteRenderer>();

//    }

//    void Update()
//    {

//        movement = new Vector2(Input.GetAxis("Horizontal"), 0).normalized;
//        movement = new Vector2(0, Input.GetAxis("Vertical")).normalized;


//        // Klavye girişini kontrol et (örneğin, A tuşuna basılırsa)
//        if (Input.GetKey(KeyCode.A))
//        {
//            // Karakter sola doğru hareket ediyorsa SpriteRenderer'ı ters çevir
//            spriteRenderer.flipX = true;
//        }
//        else
//        {
//            // Karakter sağa doğru hareket ediyorsa SpriteRenderer'ı normal hale getir
//            spriteRenderer.flipX = false;
//        }

//        HareketEt();
//    }

//    void HareketEt()
//    {
//        float dikeyInput = Input.GetAxis("Vertical");
//        float yatayInput = Input.GetAxis("Horizontal"); // "Horizontal" eksenindeki klavye girişini al

//        Vector3 hareket = new Vector3(yatayInput, dikeyInput, 0f); // Hareket vektörü oluştur
//        transform.position += hareket * speed * Time.deltaTime; // Hareketi uygula

//    }


//}

