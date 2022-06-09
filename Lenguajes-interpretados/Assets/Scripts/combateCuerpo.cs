using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combateCuerpo : MonoBehaviour
{
   
[SerializeField] private Transform controladorGolpe;

[SerializeField] private float radioGolpe;
[SerializeField] private float dañoGolpe;
private Animator animator;
private void Start() {
    animator = GetComponent<Animator>();
}
private void Update() 
{
    if(Input.GetKeyDown(KeyCode.Z))
    {
        Golpe();
    }

    
}
private void Golpe()
{
  //  animator.SetTrigger("Hit");
      Collider2D[] objetos=Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);
      foreach (Collider2D colisionador in objetos)
      {
            if (colisionador.CompareTag("Enemy"))
             {
                   colisionador.transform.GetComponent<enemyHealth>().TomarDaño(dañoGolpe);
                  
             }
      }

}

 private void OnDrawGizmos() 
 {
    

      Gizmos.color=Color.red;
      Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
}


    
}





