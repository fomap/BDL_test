﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{

    
    
   

    public float cooldownTime = 1; 
    private float nextFireTime = 0; 

   
   //Prefab
    public GameObject HookOBJ;

    
    public float speed = 10.0f;
    private float translation;
    private float straffe;

    //Camera
    public float lookSpeed = 3;
    private Vector2 rotation = Vector2.zero;
    private Transform cam;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main.transform;
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        //Camera
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.x = Mathf.Clamp(rotation.x, -40f, 40f);
        transform.eulerAngles = new Vector2(0, rotation.y) * lookSpeed;
        cam.localRotation = Quaternion.Euler(rotation.x * lookSpeed, 0, 0);

        if (Time.time > nextFireTime)
        {
              if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            nextFireTime = Time.time + cooldownTime; 

            Hook(); 
        }
        }

      
    }

    void Hook()
    {  
      
        var hook = Instantiate(HookOBJ, cam.position + cam.forward, cam.rotation);
        hook.GetComponent<NewHookScript>().caster = transform; 
        
       
    }
    
} 
