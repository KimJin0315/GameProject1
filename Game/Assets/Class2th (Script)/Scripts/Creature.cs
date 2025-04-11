using System.Collections;
using System.Collections.Generic;
using UnityEngine;

Stat stat;

public class Creature : MonoBehaviour
{
    new Stat stat;
    public Creature() // »ý¼ºÀÚ
    {
        Debug.Log("Creature");

        stat.level = 1;
        stat.health = 100;
        stat.name = "Monster";

        Debug.Log(stat.level);
        Debug.Log(stat.health);
        Debug.Log(stat.name);
    }

}

