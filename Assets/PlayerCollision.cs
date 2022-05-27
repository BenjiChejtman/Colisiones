using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3 (0, 2.77f, 0); //al poner gameObject sin mayuscula al pricipio se hace referencia al objeto que tiene el script, como cuando ponemos el transform sin especificar el objeto.
        } 
    }
    void OnCollisionExit(Collision Nocol)
    {
        if(Nocol.gameObject.name == "Plane")
        {
            transform.position = new Vector3(0, 2.77f, 0);
        }
    }

}
