using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TimeBuff - Buff, который пропадает по истечению какого-то игрового времени, независимо от вложенного в него времени
[CreateAssetMenu(fileName = "New TimeBuff", menuName = "GameFiles/TimeBuff", order = 1)]
public class TimeBuff : Buff
{
    [Header("")]
    public int time;
}
