using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplan : MonoBehaviour
{
    MeshRenderer mesh;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

   
    void Update()
    {
        float y = 0.1f * Time.time;
        mesh.material.SetTextureOffset("_MainTex", new Vector2(0, y));
    }
}
