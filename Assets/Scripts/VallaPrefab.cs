using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VallaPrefab : MonoBehaviour
{

    public GameObject []gm;
  
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gm.Length; i++)
        {
            Instantiate(gm[i]);
        }
        
     
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
