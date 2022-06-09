using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañoEnemigo : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    private  void OnTriggerStay2D(Collider2D other) {
        
     
        if(other.CompareTag("Player")){
            tiempoSiguienteDaño -=Time.deltaTime;
             if(tiempoSiguienteDaño<=0){ 

            other.GetComponent<combateVida>().TomarDaño(20);
             tiempoSiguienteDaño =tiempoEntreDaño;
             }
        
        
    }
}

 }
