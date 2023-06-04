using UnityEngine;

public static class PlayerProperty
{
    private static int maxPropertyValue = 12; //ћаксимальное значение характеристик

    private static byte _intelligence;
    private static byte _mentality;
    private static byte _physique;
    private static byte _finance;

    public static byte intelligence
    {
        get { return _intelligence; }
        set
        {
            _intelligence = (byte)Mathf.Clamp(value, 0, maxPropertyValue);
            if(value > maxPropertyValue) Debug.Log("PlayerProperty: trying to set too much value to intelligence");
        }
    }

    public static byte mentality
    {
        get { return _mentality; }
        set
        {
            _mentality = (byte)Mathf.Clamp(value, 0, maxPropertyValue);
            if (value > maxPropertyValue) Debug.Log("PlayerProperty: trying to set too much value to mentality");
        }
    }

    public static byte physique
    {
        get { return _physique; }
        set
        {
            _physique = (byte)Mathf.Clamp(value, 0, maxPropertyValue);
            if (value > maxPropertyValue) Debug.Log("PlayerProperty: trying to set too much value to physique");
        }
    }

    public static byte finance
    {
        get { return _finance; }
        set
        {
            _finance = (byte)Mathf.Clamp(value, 0, maxPropertyValue);
            if (value > maxPropertyValue) Debug.Log("PlayerProperty: trying to set too much value to finance");
        }
    }
}
