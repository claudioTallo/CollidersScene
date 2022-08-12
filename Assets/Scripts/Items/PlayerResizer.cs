using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResizer : MonoBehaviour
{
    [SerializeField]
    [Range(0.1f, 1f)]
    private float sizeOfShrink = 0.5f;
    public float SCALE { get { return sizeOfShrink; } }
}
