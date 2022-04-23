using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public AttackArea()
    {
        
    }
    
    //private int damage;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            GameObject thePlayer = GameObject.Find("Fox");
            ThirdPersonScript thirdPersonScript = thePlayer.GetComponent<ThirdPersonScript>();
            Debug.Log("US>>>: " + ThirdPersonScript.strength); //-= 10.0f;
           //damage = ;

            Health health = collider.GetComponent<Health>();
            health.Damage((ThirdPersonScript.strength));
        }
    }
}
