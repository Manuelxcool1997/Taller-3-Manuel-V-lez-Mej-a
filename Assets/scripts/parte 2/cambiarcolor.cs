using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarcolor : MonoBehaviour
{

public GameObject gameObject;
private int x;
    // Start is called before the first frame update
    void Awake()
    {
        x=1;
    }

    // Update is called once per frame
    void Update()
    {
       
if (Input.GetMouseButtonDown(1))
      {
if(x==1)
{
x=2;
Debug.Log("2");
}
else if(x==2)
{
x=3;
Debug.Log("3");
}
else if(x==3)
{
x=4;
Debug.Log("4");
}
else if(x==4)
{
x=1;
Debug.Log("1");
}
} 

if(x==1)
{
gameObject.GetComponent<MeshRenderer>().material.color = Color.red  ;
}

if(x==2)
{
gameObject.GetComponent<MeshRenderer>().material.color = Color.blue ;
}

if(x==3)
{
gameObject.GetComponent<MeshRenderer>().material.color = Color.green ;
}

if(x==4)
{
gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow ;
}

    }

public void cambiarColor()
{

}

}
