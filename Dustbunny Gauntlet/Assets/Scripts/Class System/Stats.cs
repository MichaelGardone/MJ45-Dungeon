using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{

    public int health;
    public int maxHealth;

    public int stamina;
    public int maxStamina;

    public int attack;
    public int ranged;
    public int magic;

    public int attackMod;
    public int rangedMod;
    public int magicMod;

    public int meleeDefense;
    public int rangeDefense;
    public int magicDefense;

    public int meleeDefenseMod;
    public int rangeDefenseMod;
    public int magicDefenseMod;

    public int exp;
    public int nextLevel = 25; // use Runescape's math : f(x) = [x-1+300*2^((x-1)/7))]/4
    public int level = 1;

    //TODO: Equipment array

}
