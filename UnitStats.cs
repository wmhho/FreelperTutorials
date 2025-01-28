// 1

[CreateAssetMenu(fileName = '', menuName = '')]
// TODO: Fill in the fileName and menuName
public class UnitStats : ScriptableObject
{
  [Header("Example Header 1")] // Headers are optionals, this just helps with organisation
  public string unitName;
  // TODO: Add the other necessary information and stats for each unit.

  [Header("Example Header 2")]
  public int maxHP;
  public int moveSpeed;

  // OPTIONAL TODO: Fix the headers
  
}
