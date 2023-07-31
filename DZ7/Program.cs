Console.Clear ();
Console.Write ("Введите номер дня: ");
string dayNum = Console.ReadLine ();
int numday = int.Parse (dayNum);
string day = string.Empty;

if (numday == 1){
    day = "Понедельник";
    Console.WriteLine ($"Вы ввели день {day}");
} 
else if (numday == 2) {
    day = "Вторник";
    Console.WriteLine ($"Вы ввели день {day}");
}
else if (numday == 3) {
    day = "Среда";
    Console.WriteLine ($"Вы ввели день {day}");
}
else if (numday == 4) {
    day = "Четверг";
    Console.WriteLine ($"Вы ввели день {day}");
}
else if (numday == 5) {
    day = "Пятница";
    Console.WriteLine ($"Вы ввели день {day}");
}
else if (numday == 6) {
    day = "Суббота";
    Console.WriteLine ($"Вы ввели день {day}");
}
else if (numday == 7) {
    day = "Воскресенье";
    Console.WriteLine ($"Вы ввели день {day}");
}
if (numday==7)
{
    Console.WriteLine ("Ура это выходной");
}
else if (numday==6) {
    Console.WriteLine ("Ура это выходной");
}
if (numday < 1 || numday >7) 
{
    Console.WriteLine ("Такого дня нет");
    
}
    
