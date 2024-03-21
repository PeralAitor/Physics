using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisión : MonoBehaviour
{
    // Start is called before the first frame update

    //Como el Update() pero para las colisiones (Ver si dos colliders estan chocando y le afecta las fisicas)
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Estas chocando con" + collision.collider.name);
    }

    //Como el Update() pero para los trigger(Ver si dos colliders estan chocando sin que le afecta las fisicas)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("no estas chocando con" + other.name);
    }

    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
