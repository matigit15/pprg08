using RogueArena.App.UI;
using RogueArena.Core.Characters;
using RogueArena.Core.Combat;

Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Ork", 45);

int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);

