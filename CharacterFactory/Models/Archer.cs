using CharacterFactory.Interfaces;

namespace CharacterFactory.Models;
public class Archer : BaseCharacter
{
  public Archer(string name) : base(name)
  {
    Health = 100;
    Attack = 12;
    Defense = 4;
  }

  public override void PerformAttack(ICharacter target)
  {
    base.PerformAttack(target);
    // 아처 특수 능력: 25% 확률로 연속 공격
    if (new Random().Next(100) < 25)
    {
      int arrowDamage = Attack / 2;
      target.TakeDamage(arrowDamage);
      target.TakeDamage(arrowDamage);
      Console.WriteLine($"{Name}의 연속 사격! 추가 화살 데미지 {arrowDamage * 2}!");
    }
  }
}