using CharacterFactory.Interfaces;
using CharacterFactory.Models;

namespace CharacterFactory.Factories;

public class GameCharacterFactory
{
  public ICharacter CreateCharacter(string characterType, string name)
  {
    return characterType.ToLower() switch
    {
      "warrior" => new Warrior(name),
      "mage" => new Mage(name),
      "archer" => new Archer(name),
      _ => throw new ArgumentException($"알 수 없는 캐릭터 타입입니다: {characterType}")
    };
  }
}