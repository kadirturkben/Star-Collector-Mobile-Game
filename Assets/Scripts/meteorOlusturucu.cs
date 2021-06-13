using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorOlusturucu : MonoBehaviour
{
    public GameObject meteor;
    public float mOlusturmaSuresi;
    public float zamansayaci = 0f;
    public oyuncu_kontrol scripts;
    public float zaman = 0f;

    void Start()
    {
        
    }

    
    void Update()      
    {
        if (!scripts.death)
        {
            zamansayaci -= Time.deltaTime;
            zaman += Time.deltaTime;
            float katsayi = (zaman / 10) * -70f;
            
            if (zamansayaci < 0)
            {
                GameObject go = Instantiate(meteor, new Vector3(Random.Range(-2.04f, 2.04f), 5.62f, 0), Quaternion.identity) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, katsayi, 0));
                zamansayaci = mOlusturmaSuresi;
                Destroy(go, 20);

            }
        }
       
    }
}
