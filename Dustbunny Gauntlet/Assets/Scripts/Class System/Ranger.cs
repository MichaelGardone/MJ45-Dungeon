using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : Class
{
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats
        {
            maxHealth = 8,
            health = 8,

            ranged = 2,

            meleeDefense = -1,
            rangeDefense = 2,
            magicDefense = 1
        };
    }

}
