using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Class
{
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats
        {
            maxHealth = 6,
            health = 6,

            magic = 5,

            meleeDefense = -2,
            rangeDefense = -1,
            magicDefense = 2
        };
    }

}
