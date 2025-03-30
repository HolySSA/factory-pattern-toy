using CharacterFactory.Interfaces;

namespace CharacterFactory.Models;
public abstract class BaseCharacter : ICharacter
{
  public string Name { get; set; }
  public int Level { get; set; }
  public int Health { get; set; }
  public int Attack { get; set; }
  public int Defense { get; set; }

  protected BaseCharacter(string name)
  {
      Name = name;
      Level = 1;
      Health = 100;
      Attack = 10;
      Defense = 5;
  }

  public virtual void PerformAttack(ICharacter target)
  {
      int damage = Math.Max(0, Attack - target.Defense);
      target.TakeDamage(damage);
      Console.WriteLine($"{Name}이(가) {target.Name}에게 {damage}의 데미지를 입혔습니다!");
  }

  public virtual void TakeDamage(int damage)
  {
    Health = Math.Max(0, Health - damage);
    if (Health == 0)
      Console.WriteLine($"{Name}이(가) 쓰러졌습니다!");
  }

  public virtual void LevelUp()
  {
    Level++;
    Health += 20;
    Attack += 5;
    Defense += 3;
    Console.WriteLine($"{Name}이(가) 레벨업했습니다! 현재 레벨: {Level}");
  }

  public virtual void ShowStatus()
  {
    Console.WriteLine($"=== {Name}의 상태 ===");
    Console.WriteLine($"레벨: {Level}");
    Console.WriteLine($"체력: {Health}");
    Console.WriteLine($"공격력: {Attack}");
    Console.WriteLine($"방어력: {Defense}");
    Console.WriteLine("==================");
  }
}