using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ObjetoTerceroFactory : objetosFactory
{
   public override Objetos TiposObjetos()  
        {  
            return new ObjetoPrimero();  
        } 
}
