using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Class
{

    void Start()
    {
        stats = new Stats
        {
            maxHealth = 10,
            health = 10,

            attack = 2,

            meleeDefense = 2,
            rangeDefense = 1,
            magicDefense = -1
        };
    }

}
