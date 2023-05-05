using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSystem : MonoBehaviour
{
    bool Player_Finder = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Player_Finder && Input.GetKeyDown(KeyCode.F))
       {
           print("Dialouge started!");
       }  
    }


     private void OnTriggerEnter(Collider other)
     {
          if(other.name == "Player")
          {
              Player_Finder = true;
          }
     }
     
    private void OnTriggerExit(Collider other)
    {
        Player_Finder = false;
    }  
     


}

