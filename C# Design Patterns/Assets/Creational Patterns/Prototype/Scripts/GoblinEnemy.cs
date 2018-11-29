using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype.Example.Enemies;


public class GoblinEnemy : AbstractEnemy
{
    /// <summary>
    /// Constructor that inherits from the base class
    /// </summary>
    /// <param name="uniqueID"></param>
    /// <param name="hp"></param>
    /// <param name="name"></param>
    /// <param name="enemyRace"></param>
    public GoblinEnemy(string uniqueID, int hp, string name, EnemyRace enemyRace) : base(uniqueID, hp, name, enemyRace)
    {

    }

    public override AbstractEnemy Clone()
    {
        //sloppy instantiation of an object. It could have been an Instantiate instead
        return this.MemberwiseClone() as AbstractEnemy;
    }
    public override void Interact()
    {
        Debug.LogFormat("{0} the {1} Attacked you", this.Name, this.Race);
    }



}
