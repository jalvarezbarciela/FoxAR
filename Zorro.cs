using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zorro : MonoBehaviour{
    private Animator anim;
    


    void Start()
    {
          
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Attack");
            anim.SetTrigger("Attack");
            other.gameObject.SetActive(false);
        }
    }
}