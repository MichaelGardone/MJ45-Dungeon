using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ControlManager manager;

    public float moveMulti = 5f;

    public Rigidbody2D rb;
    public Animator anim;

    private Vector2 movement = new Vector2();

    Class playerClass;

    private void Start()
    {
        playerClass = gameObject.AddComponent<Warrior>();
    }

    void Update()
    {
        movement.x = manager.Left && manager.Right ? 0 : manager.Left ? -1 : manager.Right ? 1 : 0;
        movement.y = manager.Up && manager.Down ? 0 : manager.Up ? 1 : manager.Down ? -1 : 0;

        // DELETE
        if(Input.GetKeyDown(KeyCode.B))
        {
            MeleeAttackDamage(2, 3);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            RangeAttackDamage(2, 2);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            MagicAttackDamage(5);
        }
        // DELETE

        Debug.Log(playerClass.stats.health + "/" + playerClass.stats.maxHealth);
    }

    private void LateUpdate()
    {
        rb.MovePosition(rb.position + movement * moveMulti * Time.fixedDeltaTime);
    }

    public void UpdateClass(Class player)
    {
        playerClass = player;
    }

    public void MeleeAttackDamage(int attack, int hp)
    {
        int hitAtt = Random.Range(0, hp + 1);

        if (hitAtt - playerClass.stats.meleeDefense - playerClass.stats.meleeDefenseMod > 0)
        {
            playerClass.stats.health -= Random.Range(1, attack + 1) + (hitAtt - playerClass.stats.meleeDefense - playerClass.stats.meleeDefenseMod);
            Debug.Log("melee strike hit!");
        }
        //playerClass.stats.health -= Random.Range(1, attack + 1) - playerClass.stats.meleeDefense - playerClass.stats.meleeDefenseMod;
    }

    public void RangeAttackDamage(int range, int hp)
    {
        int hitAtt = Random.Range(0, hp + 1);

        if (hitAtt - playerClass.stats.rangeDefense - playerClass.stats.rangeDefenseMod > 0)
        {
            playerClass.stats.health -= Random.Range(1, range + 1) + (hitAtt - playerClass.stats.rangeDefense - playerClass.stats.rangeDefenseMod);
            Debug.Log("range strike hit!");
        }
    }

    public void MagicAttackDamage(int magic)
    {
        int hitAtt = Random.Range(0, 11) + magic;

        if (hitAtt - playerClass.stats.magicDefense - playerClass.stats.magicDefenseMod > 0)
        {
            playerClass.stats.health -= Random.Range(1, magic + 1) + (hitAtt - playerClass.stats.magicDefense - playerClass.stats.magicDefenseMod);
            Debug.Log("magic strike hit!");
        }
    }

    public int GetHealth()
    {
        return playerClass.stats.health;
    }

    public void AwardExp(int exp)
    {
        playerClass.stats.exp += exp;

        if(playerClass.stats.exp >= playerClass.stats.nextLevel)
        {
            // based on the experience system seen in Old School Runescape
            playerClass.stats.nextLevel = (playerClass.stats.level - 1 + 100 * 2 ^ ((playerClass.stats.level - 1)/7)) / 4;
            playerClass.stats.level++;
        }

    }

}
