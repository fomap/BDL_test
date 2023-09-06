using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 


public class GlobalTime : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject timeDisplay; 
     public GameObject ScoreDisplay; 
    public int seconds = 30;
 
    public bool deductingTime;  
    
    public int score; 

    // Update is called once per frame
    void Update()
    {

        if (seconds == 0)
        {
            seconds = 0; 
            SceneManager.LoadScene(1);
            print("I saved " + score); 

        }
        else
        {
            if(deductingTime == false)
            {
            deductingTime = true; 
             StartCoroutine(DeductSecond()); 
            }
        }
      

        score = GameObject.FindGameObjectsWithTag("Enemy").Length; 

    }


    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "" + seconds; 
        deductingTime = false; 
    }

    

}
