using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour

{
    
[SerializeField] private float vida;

private Animator animator;
public int push;

private void Start()
{
      animator=GetComponent<Animator>();
}

public void TomarDaño(float daño)
{
      vida -= daño;
      if (vida <- 0)
      {
             Destroy(gameObject);
              transform.Translate(Vector3.right*push*Time.deltaTime,Space.World);
      }


}

}
