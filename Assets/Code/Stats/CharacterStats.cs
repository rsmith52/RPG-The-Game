using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    [Header("Ability Scores")]
    public Stat strength;
    public Stat dexterity;
    public Stat constitution;
    public Stat willpower;
    public Stat intelligence;
    public Stat charisma;

    [Header("Core Attributes")]
    public MeteredStat health;
    public MeteredStat mana;
    public MeteredStat stamina;

    [Header("Other Stats")]
    public Stat speed;
}
