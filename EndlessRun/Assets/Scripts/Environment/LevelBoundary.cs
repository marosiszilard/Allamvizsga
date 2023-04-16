using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    // Mennyire mehet ki a jatekos a palya szelere, ne tudjon lefutni a palyarol
    public static float leftSide = -3.25f;
    public static float rightSide = 3.25f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
       

    }
}
