using nesnelesson6;


Knight knight = new Knight("Sir Knight");

Eneym eneym = new Eneym("Bad Eneym");


while (knight.Health > 0)
{
    knight.Attack(eneym.Health);
    eneym.Attack(knight.Health);
    knight.Attack(eneym.Health);    

    Console.WriteLine($"{eneym.Name} Eneym Health:{eneym.Health} Eneym Stamina:{eneym.Stamina} Eneym Damage:{eneym.Damage} \n {knight.Name} Knight Health:{knight.Health} Knight Stamina:{knight.Stamina} Knight Damage:{knight.Damage}");
    knight.Health--;
}



