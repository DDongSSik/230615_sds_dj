using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy{
    public enum EnemyType
    { 
        Basic = 0, 
        Range,
    }

    private EnemyType enenmyType;
    private string name;
    private int hp;
    private int atk;
    private float speed;

    public Enemy(EnemyType type, string name, int hp, int atk, float speed)
    {
        this.enenmyType=type;
        //this.name = name;
        this.hp = hp;   
        this.atk = atk;
        this.speed = speed;
    }

    public int Hp
    {
        get
        {
            return this.hp;
        }
    }

    public int Atk
    {
        get
        {
            return this.atk;
        }
    }

    public float Speed
    {
        get
        {
            return this.speed;
        }
    }
    public bool Hit(int dmg)
    {
        if(this.hp - dmg <= 0) return false;

        this.hp -= dmg;

        return true;
    }


    /*public void GetEnemyInfo()
    {
        UnityEngine.Debug.Log($"name : {this.name}  hp : {this.hp}");
    }*/
  
}
