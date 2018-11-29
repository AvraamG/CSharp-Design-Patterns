
using UnityEngine;
using Prototype.Example.Enemies;
public class UnknownEnemy : AbstractEnemy
{
    public UnknownEnemy(string justID, EnemyRace justRace) : base(justID, justRace)
    {

    }

    public override AbstractEnemy Clone()
    {
        return this as AbstractEnemy;
    }

    public override void Interact()
    {
        Debug.LogFormat("{0} the {1} is Waving at you", this.Name, this.Race);
    }
}
