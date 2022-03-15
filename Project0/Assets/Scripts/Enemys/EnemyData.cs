using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName ="Enemy")]
public class EnemyData : ScriptableObject
{

    public string enemyName;
    public float enemyLife;
    public float enemyAttack;
    public int enemyLevel;

    public Sprite enemySprite;



}

