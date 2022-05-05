using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ObjetoPrimeroFactory : objetosFactory
{
   public override Objetos TiposObjetos()  
        {  
            return new ObjetoPrimero();  
        } 
}
