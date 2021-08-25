using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[System.Serializable]
public struct AbilityStruct
{
    public int hp;
    public int physicsAttack;
    public int physicsGuard;
    public int specialAttack;
    public int specialGuard;
    public int speed;
    public AbilityStruct(int hp, int a, int b, int c, int d, int s)
    {
        this.hp = hp;
        this.physicsAttack = a;
        this.physicsGuard = b;
        this.specialAttack = c;
        this.specialGuard = d;
        this.speed = s;
    }
    public static AbilityStruct operator *(AbilityStruct a,AbilityStruct b)
    {
        Func<int, float> stateMultiple = (value) =>
         {
             if (value < 0)
             {
                 return 2f / (2f - value);
             }
             else
             {
                 return (value) / 2f;
             }
         };
        var returnAbility = new AbilityStruct(0, 0, 0, 0, 0, 0);
        returnAbility.hp = a.hp;
        returnAbility.physicsAttack = (int)(a.physicsAttack * stateMultiple(b.physicsAttack));
        returnAbility.physicsGuard = (int)(a.physicsGuard * stateMultiple(b.physicsGuard));
        returnAbility.specialAttack = (int)(a.specialAttack* stateMultiple(b.specialAttack));
        returnAbility.specialGuard = (int)(a.specialGuard * stateMultiple(b.specialGuard));
        returnAbility.speed = (int)(a.speed * stateMultiple(b.speed));
        return returnAbility;

    }
}