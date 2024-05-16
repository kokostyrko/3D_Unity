using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float rightSide = 2.5f;
    public static float leftSide = -2.25f;

    public float internalRight;
    public float internalLeft;
    void Update()
    {
        internalRight = rightSide;
        internalLeft = leftSide;
    }
}
