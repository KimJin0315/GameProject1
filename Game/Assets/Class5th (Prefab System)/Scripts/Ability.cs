using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] int strength = 15;

    void Start()
    {
        Debug.Log("strengthÀÇ °ª : " + strength);
    }

}
