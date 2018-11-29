using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.Example.Enemies
{
    public abstract class AbstractEnemy : MonoBehaviour
    {
        public enum EnemyRace
        {
            goblin,
            orc,
            Murlock,
            humanoid,
            elf
        }


        private string _id;
        private int _hp;
        private string _name;
        private EnemyRace _enemyRace;

        public string ID
        {
            get
            {
                return _id;
            }
        }

        public int HP
        {
            get
            {
                return _hp;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public EnemyRace Race
        {
            get
            {
                return _enemyRace;
            }


        }

        /// <summary>
        /// Constructor with all variables
        /// </summary>
        /// <param name="uniqueID"></param>
        /// <param name="hp"></param>
        /// <param name="name"></param>
        /// <param name="enemyRace"></param>
        public AbstractEnemy(string uniqueID, int hp, string name, EnemyRace enemyRace)
        {
            this._id = uniqueID;
            this._hp = hp;
            this._name = name;
            this._enemyRace = enemyRace;

        }

        /// <summary>
        /// Constructor with just ID and Race
        /// </summary>
        /// <param name="justID"></param>
        /// <param name="justRace"></param>
        public AbstractEnemy(string justID, EnemyRace justRace)
        {
            this._id = justID;
            this._hp = 100;
            this._name = "Unamed";
            this._enemyRace = justRace;


        }

        public abstract AbstractEnemy Clone();
        public abstract void Interact();
    }
}

