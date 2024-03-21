using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCapsula : MonoBehaviour
{
    
    public float velocidad = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * velocidad * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A))
        {

            this.transform.position += Vector3.left * velocidad * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
    }
}
