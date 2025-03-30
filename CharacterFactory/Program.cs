using CharacterFactory.Factories;
using CharacterFactory.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var factory = new GameCharacterFactory();

        // 캐릭터 생성
        ICharacter warrior = factory.CreateCharacter("warrior", "전사");
        ICharacter mage = factory.CreateCharacter("mage", "마법사");
        ICharacter archer = factory.CreateCharacter("archer", "궁수");

        // 캐릭터 상태 표시
        warrior.ShowStatus();
        mage.ShowStatus();
        archer.ShowStatus();

        // 전투 시뮬레이션
        Console.WriteLine("\n=== 전투 시작! ===");

        // 전사 vs 마법사
        warrior.PerformAttack(mage);
        mage.ShowStatus();

        // 마법사 vs 궁수
        mage.PerformAttack(archer);
        archer.ShowStatus();

        // 궁수 vs 전사
        archer.PerformAttack(warrior);
        warrior.ShowStatus();

        // 레벨업
        Console.WriteLine("\n=== 레벨업! ===");
        warrior.LevelUp();
        mage.LevelUp();
        archer.LevelUp();
    }
}
