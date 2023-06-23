using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{
    private string name;
    private string job;
    private int hp;
    private int atk;

    public Character(string name, string job, int hp, int atk)
    {
        this.name = name;
        this.job = job;
        this.hp = hp;
        this.atk = atk;
    }

    public void GetCharacterInfo()
    {
        UnityEngine.Debug.Log($"name : {this.name}  job : {this.job}  hp : {this.hp}  atk : {this.atk}");
    }
}
