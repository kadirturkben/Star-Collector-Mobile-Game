using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyuncu_kontrol : MonoBehaviour
{
    
    public Text puantext;
    Rigidbody2D rig;
    public float hiz;
    public bool death;
    int puan = 0;
    int yuksekskor;
    public Joystick joystick;
    
    public AudioClip toplama, patlama;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        yuksekskor = PlayerPrefs.GetInt("Yskor");
    }

    private void FixedUpdate()
    {
        if (!death)
        {
            Vector3 kuvvet = new Vector3(joystick.Horizontal, joystick.Vertical,0); 
            rig.AddForce(kuvvet * hiz);

            float xpos = Mathf.Clamp(transform.position.x, -2.35f, 2.35f);
            float ypos = Mathf.Clamp(transform.position.y, -4.29f, 4.29f);
            transform.position = new Vector2(xpos, ypos);
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("altinYildiz"))
        {
            GetComponent<AudioSource>().PlayOneShot(toplama);
            puan += 5;
            puantext.text = puan + ""; 
            Destroy(collision.gameObject);
            if (puan > yuksekskor)
            {
                yuksekskor = puan;
                PlayerPrefs.SetInt("Yskor", yuksekskor);
            }
            else
            {
                PlayerPrefs.GetInt("Yskor");
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag.Equals("meteor"))
        {
            death = true;
            GetComponent<AudioSource>().PlayOneShot(patlama);
            
            SceneManager.LoadScene("bitis");
        }
    }
}
