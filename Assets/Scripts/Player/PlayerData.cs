using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Range(1,3)]
    private int live = 1;
    public int HP { get { return live; } }

    private Vector3 playerSize;
    private bool isDecreased = false;

    public void Healing(int inHealth)
    {
        live += inHealth;
    }

    public void Damage(int inDamage)
    {
        live -= inDamage;
    }

    public void Resize(float SCALE)
    {
        playerSize = gameObject.transform.localScale;

        Debug.Log("LA ESCALA ACTUAL ES: " + playerSize);
        if (isDecreased){
            Debug.Log("YA ESTA CHIQUITO, se agrandará");
            Increase();
            isDecreased = false;
        }
        else{
            Debug.Log("YA ESTA NORMAL, se encogerá");
            Decrease(SCALE);
            isDecreased = true;
        }       
    }

    public void Increase()
    {
        //Se agranda el jugador
        transform.localScale = new Vector3(x:1, y:1, z:1);
        Debug.Log("SE AGRANDO----");
    }

    public void Decrease(float SCALE)
    {
        //Se achica el jugador
        transform.localScale = new Vector3(x:SCALE, y:SCALE, z:SCALE);
        Debug.Log("SE ENCOGIÓ----");
    }
}
