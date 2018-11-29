using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype.Example.Enemies;
public class EnemyGenerator : MonoBehaviour
{
    public List<AbstractEnemy> enemies = new List<AbstractEnemy>();
    // Use this for initialization
    void Start()
    {
        //Originals
        UnknownEnemy unknownEnemy = new UnknownEnemy("0", AbstractEnemy.EnemyRace.elf);
        GoblinEnemy goblinEnemy = new GoblinEnemy("1", 10, "bob", AbstractEnemy.EnemyRace.goblin);
        GoblinEnemy goblinHero = new GoblinEnemy("2", 20, "Goblin Hero", AbstractEnemy.EnemyRace.goblin);


        //Clones
        UnknownEnemy unknownEnemy2 = unknownEnemy.Clone() as UnknownEnemy;
        GoblinEnemy goblinEnemy2 = goblinEnemy.Clone() as GoblinEnemy;

        unknownEnemy.Interact();
        unknownEnemy2.Interact();
        goblinEnemy.Interact();
        goblinEnemy.Interact();
        goblinHero.Interact();

        //Adding them to a list so I can manipulate them more easily
        enemies.Add(goblinEnemy2);
        enemies.Add(unknownEnemy);
        enemies.Add(unknownEnemy2);
        enemies.Add(goblinEnemy);
        enemies.Add(goblinHero);

        Debug.LogFormat(" I have {0} enemies", enemies.Count);
        Debug.Log(enemies[enemies.Count - 1].Name);

        UnknownEnemy trooperBase = new UnknownEnemy("0", AbstractEnemy.EnemyRace.humanoid);
        AttackOfTheClones(trooperBase, 50);
    }



    void AttackOfTheClones(AbstractEnemy enemyBase, int ammountOfEnemies)
    {
        for (int i = 0; i < ammountOfEnemies; i++)
        {
            AbstractEnemy newEnemy = enemyBase.Clone();
            enemies.Add(newEnemy);
            newEnemy.Interact();
        }
    }


}
