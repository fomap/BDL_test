using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labox : MonoBehaviour
{
    // Start is called before the first frame update
   

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject); 
        }
    }


}
