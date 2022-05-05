using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ObjetoSegundo : Objetos
{
    private string tipo= "SegundoTipo";

public ObjetoSegundo()
{
}
public void inicio()
{
if(GameObject.FindWithTag("sphere") == null)
{
if(GameObject.FindWithTag("cube") != null)
{
GameObject objeto = GameObject.FindWithTag("cube");   
	GameObject.Destroy(objeto);
}
if(GameObject.FindWithTag("capsule") != null)
{
GameObject objeto = GameObject.FindWithTag("capsule");   

	GameObject.Destroy(objeto);

}

GameObject sphereObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
sphereObject.tag="sphere";
sphereObject.transform.localPosition = new Vector3(0, 0, 0);
       sphereObject.transform.localScale = new Vector3(10, 10, 10);
     sphereObject.GetComponent<MeshRenderer>().material.color = Color.blue  ;
}
}


   public override string TiposObjetos
{
 
            get { return tipo; }  
}
  
}

