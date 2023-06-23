using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /*int[] arrayNumber = new int[10];
    Enemy[] enemyList = new Enemy[10];

    List<int> listNumber = new List<int>();
    List<Enemy> eList = new List<Enemy>();*/
    void Start()
    {
        /*for (int i = 0; i < enemyList.Length; i++)
        {
            Enemy e = new Enemy("elf", i);
            e.GetEnemyInfo();

            eList.Add(e);
        }


            for (int i = 0; i < enemyList.Length; i++)
        {
            enemyList[i] = new Enemy($"ai_{i}", i+10);

            enemyList[i].GetEnemyInfo();
        }*/

        Enemy e1 = new Enemy("monster", 10);
        Enemy e2 = new Enemy("monster2", 10);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();

        Character c1 = new Character("Ashe", "AD Carry", 100, 30);
        Character c2 = new Character("Sett", "Bruiser", 130, 20);
        Character c3 = new Character("Ezreal", "AD Carry", 90, 30);
        Character c4 = new Character("KhaZix", "Assassin", 80, 30);

        c1.GetCharacterInfo();
        c2.GetCharacterInfo();
        c3.GetCharacterInfo();
        c4.GetCharacterInfo();
    }

    void CreateCharacter(Character character)
    {

    }

    void RemoveCharacter(int index)
    {

    }

    void PrintAllCharacter()
    {
        //while문으로 작성
        //생성된 캐릭터가 없을 때 : 리스트가 비어있습니다.
    }


}
