using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DeBuff - Buff с возможностью снятия за определённую цену
[CreateAssetMenu(fileName = "New DeBuff", menuName = "GameFiles/DeBuff", order = 1)]
public class DeBuff : Buff
{
    [Header("")]
    public int price;
}
