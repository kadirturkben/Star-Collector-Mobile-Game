using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yildiz_hareket : MonoBehaviour
{
    public float hiz;

    void Start()
    {
        Destroy(gameObject,3f);
    }

   
    void FixUpdate()
    {
        transform.position += Vector3.down * hiz * Time.deltaTime;
    }
}
