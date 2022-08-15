using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Range(1,3)]
    private int live = 1;
    public int HP { get { return live; } }

    [SerializeField] private bool isDecreased = false;

    private Vector3 playerSize;
    private Vector3 originalSize;

    private PlayerResizer playerResizer;

    private void Start() {
        playerResizer = GetComponent<PlayerResizer>();
        originalSize = gameObject.transform.localScale;
    }

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
        playerSize = gameObject.transform.localScale;   //obtiene la escala actual
        Debug.Log(playerResizer.SCALE);
        Debug.Log("LA ESCALA ACTUAL ES: " + playerSize);
        if (!isDecreased){
            Debug.Log("TAMAÑO NORMAL, encogiendo...");
            Decrease(playerResizer.SCALE);              //llama a la función de disminuir tamaño, pasandole el valor de PlayerResizer
            isDecreased = true;                         //Seteo el booleano de disminuido a verdadero
        }
        else{
            Debug.Log("TAMAÑO PEQUEÑO, crecerá al tamaño original");
            Increase();
            isDecreased = false;
        }       
    }

    public void Increase()
    {
        //Se agranda el jugador
        transform.localScale = originalSize; //se le asigna la escala configurada por defecto (1,1,1)
        Debug.Log("SE AGRANDO----");
    }

    public void Decrease(float SCALE)
    {
        //Se achica el jugador
        transform.localScale = new Vector3(x:SCALE, y:SCALE, z:SCALE); //Se le cambia la escala local a la escala enviada desde PlayerResizer
        Debug.Log("SE ENCOGIÓ----");
    }
}
