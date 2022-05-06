using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colicionCapsula : MonoBehaviour
{

public ParticleSystem _psystem;
    // Start is called before the first frame update
    void Awake()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter (Collider col)  {
 
   
                  _psystem.Play();
       }
}
