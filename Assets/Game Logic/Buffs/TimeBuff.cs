using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TimeBuff - Buff, ������� ��������� �� ��������� ������-�� �������� �������, ���������� �� ���������� � ���� �������
[CreateAssetMenu(fileName = "New TimeBuff", menuName = "GameFiles/TimeBuff", order = 1)]
public class TimeBuff : Buff
{
    [Header("")]
    public int time;
}
