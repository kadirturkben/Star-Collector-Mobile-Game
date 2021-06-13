using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altin_YildizSpawn : MonoBehaviour
{
    public GameObject altinyildiz;
    public float yolusturmaSuresi;
    public float zamansayaci = 0f;
    public oyuncu_kontrol kontrol;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (!kontrol.death)
        {
            zamansayaci -= Time.deltaTime;
            if (zamansayaci < 0)
            {

                GameObject a = Instantiate(altinyildiz, new Vector3(Random.Range(-2.04f, 2.04f), Random.Range(-4.48f, 3.54f), 0), Quaternion.identity) as GameObject;
                zamansayaci = yolusturmaSuresi;
                Destroy(a, 3);
            }
        }
    }
}
