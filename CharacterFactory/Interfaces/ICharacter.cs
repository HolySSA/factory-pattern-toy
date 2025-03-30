namespace CharacterFactory.Interfaces;

public interface ICharacter
{
  string Name { get; set; }
  int Level { get; set; }
  int Health { get; set; }
  int Attack { get; set; }
  int Defense { get; set; }

  void PerformAttack(ICharacter target);
  void TakeDamage(int damage);
  void LevelUp();
  void ShowStatus();
}