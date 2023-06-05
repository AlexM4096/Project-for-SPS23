[System.Serializable]
public struct Stats
{
    public int Intelligence;
    public int MentalHealth;
    public int PhysicalHealth;
    public int Finance;
    public int Socialization;
    public int Creativity;

    static public Stats operator +(Stats a, Stats b)
    {
        a.Intelligence += b.Intelligence;
        a.MentalHealth += b.MentalHealth;
        a.PhysicalHealth += b.PhysicalHealth;
        a.Finance += b.Finance;
        a.Socialization += b.Socialization;
        a.Creativity += b.Creativity;
        return a;
    }
}
