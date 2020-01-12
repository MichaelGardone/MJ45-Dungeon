using System.Collections;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{

    Queue nextLives = new Queue();

    public Player player;

    // Update is called once per frame
    void Update()
    {
       if(player.GetHealth() <= 0 && nextLives.Count == 0)
       {
            Debug.Log("game over");
       }

       if(player.GetHealth() == 0 && nextLives.Count > 0)
       {
            player.UpdateClass(GetLife());
       }

    }

    public void AddLives(Class next)
    {
        nextLives.Enqueue(next);
    }

    public Class GetLife()
    {
        return (Class)nextLives.Dequeue();
    }

}
