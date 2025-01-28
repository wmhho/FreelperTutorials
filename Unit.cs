// 2

public class Unit : MonoBehaviour
{
    public UnitStats baseStats; // Reference to ScriptableObject

    public int currHP;
    public int level; // TODO: There isn't a level currently, add it and any other variables you need into this and the ScriptableObject

    void Start()
    {
        InitializeUnit();
    }

    void InitializeUnit()
    {
        // TODO: Set the base stats you need to initialise the unit.
        // The first is done for you, do the rest yourself
        currHP = baseStats.maxHP;
    }

    // OPTIONAL TODO: add more functions that can affect a unit
}
