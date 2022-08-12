using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Range(1,3)]
    private int live = 1;
    public int HP { get { return live; } }

    [SerializeField]
    [Range(1,2)]
    private int playerScale = 1;
    public int SCALE { get { return playerScale; } }

    public void Healing(int value)
    {
        live += value;
    }

    public void Damage(int value)
    {
        live -= value;
    }

    public void Increase()
    {

    }

    public void Decrease()
    {
        
    }
}
