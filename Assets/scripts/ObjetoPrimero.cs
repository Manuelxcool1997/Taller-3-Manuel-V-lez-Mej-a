using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ObjetoPrimero : Objetos
{
 
private string tipo= "primerTipo";

public ObjetoPrimero()
{

}

public void inicio()
{
if(GameObject.FindWithTag("cube") == null)
{
if(GameObject.FindWithTag("sphere") != null)
{
GameObject objeto = GameObject.FindWithTag("sphere");   
GameObject.Destroy(objeto);
}
if(GameObject.FindWithTag("capsule") != null)
{
GameObject objeto = GameObject.FindWithTag("capsule");   
GameObject.Destroy(objeto);
}

GameObject cubeObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
cubeObject.tag="cube";
cubeObject.transform.localPosition = new Vector3(0, 0, 0);
        cubeObject.transform.localScale = new Vector3(10, 10, 10);
        cubeObject.GetComponent<MeshRenderer>().material.color = Color.red  ;

}
}
void Start()
{

}

   public override string TiposObjetos
{
 
            get { return tipo; }  
}
  
}
