using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skill - Buff � ������������ �������� �� ����������� ����
[CreateAssetMenu(fileName = "New Skill", menuName = "GameFiles/Skill", order = 1)]
public class Skill : Buff
{
    [Header("")]
    public int maxlevel = 5;
    public int startprice;
    public int multiplierprice = 2;
}
