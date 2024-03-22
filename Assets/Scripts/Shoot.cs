using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public float fuerza = 1000f;
    public GameObject bala;

    // Start is called before the first frameS update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    private void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject objeto = Instantiate(bala,new Vector3(this.transform.position.x - 2, this.transform.position.y, this.transform.position.z),Quaternion.identity);
            objeto.GetComponent<Rigidbody>().AddForce(Vector3.left * fuerza);
        }
    }

}
