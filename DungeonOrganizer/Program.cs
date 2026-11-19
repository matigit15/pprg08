
using DungeonOrganizer.Characters;
using DungeonOrganizer.Items;
using DungeonOrganizer.UI;
using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
Item item = new Item("Mikstura", 15);
Weapon weapon = new Weapon("Miecz",8);
InventoryItem Iitem = new InventoryItem("Mikstura",15);
MapItem mapa = new MapItem("!");

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);
GamePrinter.ShowIitem(Iitem.Name, Iitem.Price);
GamePrinter.ShowMap(mapa.Symbol);
