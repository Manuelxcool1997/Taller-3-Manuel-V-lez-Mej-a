using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ObjetoTercero : Objetos
{
   private string tipo= "tercerTipo";

public ObjetoTercero()
{
}
public void inicio()
{
if(GameObject.FindWithTag("capsule") == null)
{
if(GameObject.FindWithTag("cube") != null)
{
GameObject objeto = GameObject.FindWithTag("cube");   

	GameObject.Destroy(objeto);
}
if(GameObject.FindWithTag("sphere") != null)
{
GameObject objeto = GameObject.FindWithTag("sphere");   
GameObject.Destroy(objeto);
}

GameObject CapsuleObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);

CapsuleObject.tag="capsule";

CapsuleObject.transform.localPosition = new Vector3(0, 0, 0);
        CapsuleObject.transform.localScale = new Vector3(10, 10, 10);
        CapsuleObject.GetComponent<MeshRenderer>().material.color = Color.green ;
}
}


   public override string TiposObjetos
{
 
            get { return tipo; }  
}
}
