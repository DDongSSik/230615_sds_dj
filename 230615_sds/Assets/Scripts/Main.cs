using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    int[] arrayNumber = new int[10];
    Enemy[] enemyList = new Enemy[10];

    List<int> listNumber = new List<int>();
    List<Enemy> eList = new List<Enemy>();
    void Start()
    {
        for (int i = 0; i < enemyList.Length; i++)
        {
            Enemy e = new Enemy("elf", i);
            e.GetEnemyInfo();

            eList.Add(e);
        }


            for (int i = 0; i < enemyList.Length; i++)
        {
            enemyList[i] = new Enemy($"ai_{i}", i+10);

            enemyList[i].GetEnemyInfo();
        }

        Enemy e1 = new Enemy("monster", 10);
        Enemy e2 = new Enemy("monster2", 10);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();
    }
   
}