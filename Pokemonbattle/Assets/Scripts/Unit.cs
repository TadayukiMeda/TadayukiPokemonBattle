using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit: MonoBehaviour
{
    public string taipu;
    public int hp;
    public int power;
    public int speed;
    public Text battleLogText;
    public Slider hpSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Attack(Unit target)
    {
        
        Debug.Log(target.hp);
        if (target.hp < 0)
        {
            target.hp = 0;
        }
        System.Random r = new System.Random();
        int Randomvalue = r.Next(3);

        int damage;
        /*
        if (Randomvalue < 3)
        {
           damage = this.power *2;
            
        }
        else
        {
            damage = this.power;
        }
        */
        if(this.taipu == "glass")
        {
            if (target.taipu == "water")
            {
                battleLogText.text += "効果は抜群だ！！\n";
                damage = this.power * 2;
            }
            else if (target.taipu == "fire")
            {
                battleLogText.text += "効果いまひとつ\n";
                damage = this.power / 2;
            }
            else
            {
                battleLogText.text += "効果あり\n";
                damage = this.power;
            }
            

        }
        else
        {
            damage = this.power;
        }
        if (target.taipu == "ground")
        {
            if (this.taipu == "fire")
            {
                battleLogText.text += "効果は抜群だ";
                damage = target.power * 2;
            }
            else if (this.taipu == "water")
            {
                battleLogText.text += "効果いまひとつ\n";
                damage = target.power / 2;
            }
            else
            {
                battleLogText.text += "効果あり\n";
                damage = target.power;
            }
        }
        else
        {
            damage = target.power;
        }

        target.hp = target.hp - damage;

        if(target.hp < 0)
        {
            target.hp = 0;
        }

        return damage;
    }
}
