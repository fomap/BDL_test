using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinking : MonoBehaviour
{
    
  


    Vector3 temp; 
    Vector3 stopper =   new Vector3(1f, 1.0f, 1f); 
    // Start is called before the first frame update
    void Start()
    {   
    
         InvokeRepeating("Ayaya", 0f, 0.1f); 
    }

    // Update is called once per frame
    void Update()
    {

          
            
        
       
    }


    void Ayaya()
    {
             temp = transform.localScale;
             if (temp.x > stopper.x)
             {
                temp.x -= Time.deltaTime; 
                temp.z -= Time.deltaTime; 
                transform.localScale = temp;  
                
             }
             else
             {
                return; 
             }
             
    }



}
