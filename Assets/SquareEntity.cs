using Realms;

class SquareEntity : RealmObject
{
    [PrimaryKey]
    public string PrimaryKey { get; set; }

    public float Red { get; set; }  = 1f;
    public float Green { get; set; } = 1f;
    public float Blue { get; set; } = 1f;

    public SquareEntity(string primaryKey)
    {
        PrimaryKey = primaryKey;
    }
}