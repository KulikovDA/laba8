//базовый 9
// 1
Console.WriteLine("Текущая дата: " + DateTime.Now.ToShortDateString());
// 2
Console.WriteLine("Введите время начала телепередачи в формате ЧЧ:ММ: ");
string startTime = Console.ReadLine();
Console.WriteLine("Введите продолжительность телепередачи в секундах: ");
int dolgo = Convert.ToInt32(Console.ReadLine());
TimeSpan start = TimeSpan.Parse(startTime);
TimeSpan end = start.Add(new TimeSpan(0, 0, dolgo));
Console.WriteLine("Время окончания телепередачи: " + end);
int dolgoM = dolgo / 60;
Console.WriteLine("Продолжительность телепередачи: " + dolgoM + " минут");
int reklama = dolgoM / 5;
Console.WriteLine("Количество рекламных пауз: " + reklama);