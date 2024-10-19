using CompositeDemo.SingleEquipment;
using CompositeDemo.CompoundEquipment;

Helmet helmet = new Helmet(Material.Leather);
BreastPlate breastPlate = new BreastPlate(Material.Diamond);
LegArmor legArmor = new LegArmor(Material.Gold);
Boots boots = new Boots(Material.Iron);

Armor armor = new Armor();
armor.ArmorPieces.Add(helmet);
armor.ArmorPieces.Add(breastPlate);
armor.ArmorPieces.Add(legArmor);
armor.ArmorPieces.Add(boots);

while (true)
{
    armor.GetPiecesDurability();
    Console.WriteLine("Press 1 to hit the armor (7)");
    Console.WriteLine("Press 2 to fix the armor (5)");
    string? key = Console.ReadLine();
    switch (key)
    {
        case "1":
            armor.WornOut(7);
            armor.GetPiecesDurability();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            break;
        case "2":
            armor.Fix();
            armor.GetPiecesDurability();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            break;
        default:
            Console.Clear();
            break;
    }
}