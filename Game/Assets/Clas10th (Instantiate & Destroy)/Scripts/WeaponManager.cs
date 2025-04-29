using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject [] weapons;
    [SerializeField] List<GameObject> weaponList;

    [SerializeField] Transform parentPostion;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            Instantiate(weapons[i], parentPostion);
        }

    }

    void Update()
    {
        if(//스페이스바 눌렸을 때)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                weaponList.Add(weapons[i]);

                GameObject.SetActive(weapons[i - 1]) = false;
            }
        }
        
    }

}
