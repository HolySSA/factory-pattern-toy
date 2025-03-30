using CharacterFactory.Interfaces;

namespace CharacterFactory.Models;
public class Mage : BaseCharacter
{
  public Mage(string name) : base(name)
  {
    Health = 80;
    Attack = 20;
    Defense = 3;
  }

  public override void PerformAttack(ICharacter target)
  {
    base.PerformAttack(target);
    // 마법사 특수 능력: 30% 확률로 마법 공격
    if (new Random().Next(100) < 30)
    {
      int magicDamage = Attack * 2;
      target.TakeDamage(magicDamage);
      Console.WriteLine($"{Name}의 마법 공격! 마법 데미지 {magicDamage}!");
    }
  }
}