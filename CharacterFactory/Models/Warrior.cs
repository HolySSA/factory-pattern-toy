using CharacterFactory.Interfaces;

namespace CharacterFactory.Models;
public class Warrior : BaseCharacter
{
  public Warrior(string name) : base(name)
  {
    Health = 150;
    Attack = 15;
    Defense = 8;
  }

  public override void PerformAttack(ICharacter target)
  {
    base.PerformAttack(target);
    // 전사 특수 능력: 20% 확률로 추가 데미지
    if (new Random().Next(100) < 20)
    {
      int bonusDamage = Attack / 2;
      target.TakeDamage(bonusDamage);
      Console.WriteLine($"{Name}의 특수 공격! 추가 데미지 {bonusDamage}!");
    }
  }
}
