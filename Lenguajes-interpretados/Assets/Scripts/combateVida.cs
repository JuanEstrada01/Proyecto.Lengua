using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combateVida : MonoBehaviour
{
    
[SerializeField] private float vida;

[SerializeField] private float maximovida;
[SerializeField] private barraDeVida barraDeVida;
private void Start()
{
   vida=maximovida;
   barraDeVida.InicializarBarraDeVida(vida);
 }

public void TomarDaño(float daño)
{
   vida -= daño;
   barraDeVida.CambiarVidaActual(vida);
   if (vida <= 0)
   {
        Destroy(gameObject);
   }
}
public void Curar(float curacion){

    if((vida + curacion)> maximovida){
        vida = maximovida;
    }
    else{
        vida+= curacion;
    }
}


}
