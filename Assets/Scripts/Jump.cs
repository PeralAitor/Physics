using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

   public float fuerza = 10.0f;
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpIsNeded();
    }

    public void jumpIsNeded()
    {
        if (canJump && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Espacio Pulsado");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * fuerza, ForceMode.Force);
        }
    }

   void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == GameObject.Find("Plane").name)
        {
            canJump = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
}
