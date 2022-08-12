using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerData playerData;

    private void Start()
    {
        playerData = GetComponent<PlayerData>();
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Powerups"))
        {
            Debug.Log("ENTRANDO EN COLISION CON: " + other.gameObject.name);
            Destroy(other.gameObject);
            //sumar vida
            playerData.Healing(other.gameObject.GetComponent<Pumpkin>().HealPoints);
        }

        if (other.gameObject.CompareTag("Munitions"))
        {
            Debug.Log("ENTRANDO EN COLISION CON: " + other.gameObject.name);
            playerData.Damage(other.gameObject.GetComponent<Munition>().DamagePoints);
            Destroy(other.gameObject);
            if (playerData.HP <= 0)
            {
                Debug.Log("GAME OVER");
            }
        }

    }

    private void OnCollisionExit(Collision other)
    {
        //Debug.Log("SALGO DE LA COLISION ->" + other.gameObject.name);

    }

    private void OnTriggerEnter(Collider other)
    {


        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Portals"))
        {

        }
        
    }

    private void OnTriggerStay(Collider other)
    {

    }
}
