using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{

    [SerializeField]
    [Range(2, 10)]
    private float cooldown;

    [SerializeField]
    Transform nextPortal;

    private float timeInPortal = 0;

    private PlayerData playerData;
    private PlayerResizer playerResizer;

    private void Start()
    {
        playerResizer = GetComponent<PlayerResizer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTANDO EN TRIGGER CON ->" + other.gameObject.name);
        timeInPortal = 0;

        if (other.gameObject.CompareTag("Player"))
        {
            PlayerData playerReference = other.gameObject.GetComponent<PlayerData>();
            float indexedScale = playerResizer.SCALE;
            playerReference.Resize(indexedScale);
        }






/*         {
            PlayerData playerReference = other.gameObject.GetComponent<PlayerData>();

            if(playerReference != null)
            {
                Debug.Log("HE TOCADO A: " + other.gameObject.name);
                float indexedScale = playerResizer.SCALE;
                playerReference.Resize(indexedScale);
            }
            else Debug.Log("es nulo");
        } */

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("SALIENDO DEL TRIGGER ->" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(" EN EL TRIGGER ->" + other.gameObject.name);
        timeInPortal += Time.deltaTime;
        // Debug.Log(timeInPortal);
        if (timeInPortal >= cooldown)
        {
            other.transform.position = nextPortal.position;
        }

    }
}
