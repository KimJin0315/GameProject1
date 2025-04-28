using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform parentPostion;

    [SerializeField] WeaponManager clone;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, parentPostion);

        
        Debug.Log(" ");
    }
}
