using System.IO;

StreamReader sr = new StreamReader(@"C:\Users\HoxtonG\Desktop\task1.txt"); //Создание нашего текстового файла

//Переменные для считывания длинны подстроки
int a = 0; 
int b = 0; 

string task = sr.ReadToEnd();// Обозначение нашего текстового файла

for (int i = 0; i < task.Length; i++) //цикл с проверкой 
{
    if (task[i] == 'A' || task[i] == 'E')//проверка нету ли в строке гласных
    {
        if (a < b)
        {
            a = b;
        }
        b = 0;
    }
    else
    {
        b++;
    }
}
Console.WriteLine("Подстрока без гласных имеет длинну: " + a);
Console.ReadKey();


//Информация которую читал/смотрел для решения задачи:
//https://metanit.com/sharp/tutorial/5.5.php
//https://www.youtube.com/watch?v=ltvFrWCqL6g&t=686s&ab_channel=XpucT