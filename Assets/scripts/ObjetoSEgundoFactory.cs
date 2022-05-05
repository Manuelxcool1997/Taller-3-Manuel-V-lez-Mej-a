using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ObjetoSegundoFactory : objetosFactory
{
    public override Objetos TiposObjetos()  
        {  
            return new ObjetoSegundo();  
        } 
}
