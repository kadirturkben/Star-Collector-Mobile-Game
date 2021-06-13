using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yildiz_spawner : MonoBehaviour
{
    public GameObject yildizlar;
    public float konum;
    public oyuncu_kontrol oyuncuScript;

    void Start()
    {
        StartCoroutine(spawnObject());
    }

    
    void Update()
    {
        
    }
    public IEnumerator spawnObject()
    {
        while (!oyuncuScript.death)
        {
            Instantiate(yildizlar, new Vector3(Random.Range(-konum, konum), 3.62f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);

        }
        
    }
}
